using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;
using MWMROrleansInterfaces;
using MWMROrleansGrains;

namespace MWMROrleans
{
    //public class MetadataGrainFactory : IMetadataGrainFactory
    //{
    //    private static readonly ConcurrentDictionary<Type, Dictionary<string, Type>> readerWriterMapping
    //        = new ConcurrentDictionary<Type, Dictionary<string, Type>>(); 

    //    public void registerReaderWriterType(Type state, Type reader, Type writer)
    //    {
    //        Dictionary<string, Type> rwtype = new Dictionary<string, Type>();
    //        rwtype.Add("read", reader);
    //        rwtype.Add("write", writer);

    //        readerWriterMapping.TryAdd(state, rwtype);
    //    }

    //    public TGrainInterface GetGrain<TGrainInterface>(long primaryKey, bool readwrite = false, string grainClassNamePrefix = null) where TGrainInterface : IGrainWithIntegerKey
    //    {
    //        Dictionary<string, Type> rwtype = readerWriterMapping[typeof(TGrainInterface)];
    //        if (readwrite == true)
    //        {
    //            Type writeType = rwtype["write"];
    //            return Orleans.GrainClient.GrainFactory.GetGrain<TGrainInterface>(0);
    //        }
    //        else
    //        {
    //            return Orleans.GrainClient.GrainFactory.GetGrain<IStatefulGrainReader>(0);
    //        }

    //        return Cast<TGrainInterface>(
    //            GrainFactoryBase.MakeGrainReference_FromType(
    //                baseTypeCode => TypeCodeMapper.ComposeGrainId(baseTypeCode, primaryKey, typeof(TGrainInterface)),
    //                typeof(TGrainInterface),
    //                grainClassNamePrefix));
    //    } 
    //}

    public static class MetadataGrainFactory
    {
        private static IStatefulGrainReader reader = new StatefulGrainReader();
        private static IStatefulGrainWriter writer = new StatefulGrainWriter(); 

        public static IStatefulGrain GetGrain(long primaryKey, bool readwrite = false, string grainClassNamePrefix = null)
        {
            IStatefulGrain grain = null;
            if (readwrite == true)
            {
                grain = writer;
            }
            else
            {
                grain = reader;
            }

            return grain;
        }
    }
}
