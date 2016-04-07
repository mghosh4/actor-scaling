using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Orleans;
using MWMROrleansInterfaces;

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
        private static readonly Dictionary<string, IStatefulGrain> readerGrains =
            new Dictionary<string, IStatefulGrain>();
        private static readonly Dictionary<string, IStatefulGrain> writerGrains =
            new Dictionary<string, IStatefulGrain>();

        public static IStatefulGrain GetGrain(string primaryKey, bool readwrite = false, string grainClassNamePrefix = null)
        {
            IStatefulGrain grain = null;
            string dictkey = primaryKey;
            if (readwrite == true)
                dictkey = dictkey + "w";
            else
                dictkey = dictkey + "r";

            if (readerGrains.ContainsKey(dictkey))
            {
                readerGrains.TryGetValue(dictkey, out grain);
                return grain;
            }
            else if (writerGrains.ContainsKey(dictkey))
            {
                writerGrains.TryGetValue(dictkey, out grain);
                return grain;
            }

            if (readwrite == true)
            {
                grain = Orleans.GrainClient.GrainFactory.GetGrain<IStatefulGrainWriter>(dictkey, grainClassNamePrefix);
                writerGrains.Add(dictkey, grain);
                Console.WriteLine("\n\n{0},{1}\n\n", writerGrains.Count, readerGrains.Count);
            }
            else
            {
                grain = Orleans.GrainClient.GrainFactory.GetGrain<IStatefulGrainReader>(dictkey, grainClassNamePrefix);
                readerGrains.Add(dictkey, grain);
                Console.WriteLine("\n\n{0},{1}\n\n", writerGrains.Count, readerGrains.Count);
            }

            return grain;
        }

        public static List<IStatefulGrain> GetAllGrains()
        {
            Console.WriteLine("\n\n{0},{1}\n\n", writerGrains.Count, readerGrains.Count);

            List<IStatefulGrain> grains = new List<IStatefulGrain>();
            foreach (KeyValuePair<string, IStatefulGrain> entry in readerGrains)
            {
                // do something with entry.Value or entry.Key
                grains.Add(entry.Value);
            }

            foreach (KeyValuePair<string, IStatefulGrain> entry in writerGrains)
            {
                // do something with entry.Value or entry.Key
                grains.Add(entry.Value);
            }

            return grains;
        }
    }
}
