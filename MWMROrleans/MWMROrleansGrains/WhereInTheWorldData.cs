using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Orleans.Concurrency;
using Orleans.Providers;

using MWMROrleansInterfaces;

namespace MWMROrleansGrains
{
    /// <summary>
    /// Grain implementation class Grain1.
    /// </summary>
    [StorageProvider(ProviderName = "MemoryStore")]
    public class WhereInTheWorldDataGrain : StronglyConsistentWriter, MWMROrleansInterfaces.IWhereInTheWorldData
    {
        public DateTime? leaseRenewTime;

        private bool WithinLeasePeriod()
        {
            if (leaseRenewTime.HasValue && (DateTime.Now - leaseRenewTime) <= Parameters.LEASE_DURATION)
                return true;

            return false;
        }

        private IWITWDMetadataGrain GetMetadataGrain()
        {
            return GrainFactory.GetGrain<IWITWDMetadataGrain>(0);
        }

        public Task StartLease(DateTime time)
        {
            leaseRenewTime = time;
            return TaskDone.Done;
        }

        public override async Task<Context> SetValue(KeyValuePair<string, string> entry)
        {
            if (WithinLeasePeriod())
            {
                Context context = await base.SetValue(entry);
                return context;
            }
            else
            {
                Context context = await GetMetadataGrain().GetNearestFullReplica().Result.SetValue(entry);
                return context;
            }

        }

        public override async Task<Context> ClearValues()
        {
            if (WithinLeasePeriod())
            {
                Context context = await base.ClearValues();
                return context;
            }
            else
            {
                Context context = await GetMetadataGrain().GetNearestFullReplica().Result.ClearValues();
                return context;
            }
        }

        public override async Task<string> GetValue(string key, Context cntxt)
        {
            if (WithinLeasePeriod())
            {
                string result = await base.GetValue(key, cntxt);
                return result;
            }
            else
            {
                string value = await GetMetadataGrain().GetNearestFullReplica().Result.GetValue(key, cntxt);
                return value;
            }
        }

        public override async Task<IDictionary<string, string>> GetAllEntries(Context cntxt)
        {
            if (WithinLeasePeriod())
            {
                var result = await base.GetAllEntries(cntxt);
                return result;
            }
            else
            {
                var value = await GetMetadataGrain().GetNearestFullReplica().Result.GetAllEntries(cntxt);
                return value;
            }
        }

        public override async Task updateOtherGrainState()
        {
            IWITWDMetadataGrain metadatagrain = GetMetadataGrain();
            var fullReplicas = metadatagrain.GetAllFullReplicas().Result;
            foreach (string entry in fullReplicas)
            {
                IStatefulGrain stategrain = await metadatagrain.GetGrain(entry, false, ConsistencyLevel.EVENTUAL);
                await stategrain.SetState(State);
                break;
            }
        }
    }

    [StorageProvider(ProviderName = "MemoryStore")]
    public class WITWDMetadataGrain : Grain<WITWDMetadataGrainState>, MWMROrleansInterfaces.IWITWDMetadataGrain
    {
        public const string WITWD_REPLICA = "witwd";

        public Random rnd = new Random();

        public override async Task OnActivateAsync()
        {
            if (State.replicas == null)
                State.replicas = new Dictionary<string, DateTime>();

            State.numInstances = 0;

            await base.OnActivateAsync();
        }

        public Task<IStatefulGrain> GetGrain(bool readwrite, ConsistencyLevel level)
        {
            return GetGrain();
        }

        public Task<IStatefulGrain> GetGrain(string primaryKey, bool readwrite, ConsistencyLevel level)
        {
            return Task.FromResult<IStatefulGrain>(GrainFactory.GetGrain<IStatefulGrain>(primaryKey));
        }

        public Task<IStatefulGrain> GetGrain()
        {
            string primaryKey = null;
            bool renewlease = true;
            if (State.numInstances >= Parameters.NUM_REPLICAS)
            {
                var stubReplicas = State.replicas.Where(x => DateTime.Now - x.Value > Parameters.LEASE_DURATION);
                if (stubReplicas.Count() > 0)
                    primaryKey = stubReplicas.ElementAt(rnd.Next(0, stubReplicas.Count())).Key;
                else
                {
                    primaryKey = State.replicas.ElementAt(rnd.Next(0, Parameters.NUM_REPLICAS)).Key;
                    renewlease = false;
                }
            }
            else
                primaryKey = WITWDMetadataGrain.WITWD_REPLICA + State.numInstances++;

            IWhereInTheWorldData grain = GrainFactory.GetGrain<IWhereInTheWorldData>(primaryKey);
            if (renewlease)
            {
                var leaseStartTime = DateTime.Now;
                grain.StartLease(leaseStartTime);
                State.replicas.Add(primaryKey, leaseStartTime);
            }

            return Task.FromResult<IStatefulGrain>(grain);
        }

        public Task<IWhereInTheWorldData> GetNearestFullReplica()
        {
            // Adding some offset so that we do not pick replica whose lease is soon to expire
            var fullReplicas = State.replicas.Where(x => DateTime.Now - x.Value <= Parameters.LEASE_DURATION - new TimeSpan(0,3,0));
            if (fullReplicas.Count() > 0)
            {
                string primaryKey = fullReplicas.ElementAt(rnd.Next(0, fullReplicas.Count())).Key;
                IWhereInTheWorldData grain = GrainFactory.GetGrain<IWhereInTheWorldData>(primaryKey);
                return Task.FromResult<IWhereInTheWorldData>(grain);
            }

            return null;
        }

        public Task<List<string>> GetAllFullReplicas()
        {
            // Adding some offset so that we do not pick replica whose lease is soon to expire
            return Task.FromResult<List<String>>(State.replicas.Where(x => DateTime.Now - x.Value <= Parameters.LEASE_DURATION).Select(x => x.Key).ToList());
        }
    }

    [Serializable]
    public class WITWDMetadataGrainState : GrainState
    {
        public IDictionary<string, DateTime> replicas { get; set; }

        public int numInstances;
    }
}
