/*
Project Orleans Cloud Service SDK ver. 1.0
 
Copyright (c) Microsoft Corporation
 
All rights reserved.
 
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the ""Software""), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;

using MWMROrleansInterfaces;

namespace MWMROrleansHost
{
    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            });

            Orleans.GrainClient.Initialize("DevTestClientConfiguration.xml");

            BasicTest();

            // TODO: once the previous call returns, the silo is up and running.
            //       This is the place your custom logic, for example calling client logic
            //       or initializing an HTTP front end for accepting incoming requests.

            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");
            Console.ReadLine();

            hostDomain.DoCallBack(ShutdownSilo);
        }

        private static void BasicTest()
        {
            var metadatagrain = Orleans.GrainClient.GrainFactory.GetGrain<IMetadataGrain>(0);

            var stopwatch = Stopwatch.StartNew();
            Task<IStatefulGrain> writertsk = metadatagrain.GetGrain(true, ConsistencyLevel.STRONG);
            writertsk.Wait();
            IStatefulGrain writer = writertsk.Result;
            stopwatch.Stop();
            Console.WriteLine("Time to create a writer {0}", stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            Task<IStatefulGrain> readertsk = metadatagrain.GetGrain(false, ConsistencyLevel.STRONG);
            readertsk.Wait();
            IStatefulGrain reader = readertsk.Result;
            stopwatch.Stop();
            Console.WriteLine("Time to create a reader {0}", stopwatch.ElapsedMilliseconds);

            stopwatch.Start();
            Task<Context> tskcnt = writer.SetValue(new KeyValuePair<string, string>("hello", "1"));
            tskcnt.Wait();
            Context cnt = tskcnt.Result;
            stopwatch.Stop();
            Console.WriteLine("Time to first write {0}", stopwatch.ElapsedMilliseconds);

            writer.SetValue(new KeyValuePair<string, string>("how", "2")).Wait();
            writer.SetValue(new KeyValuePair<string, string>("are", "3")).Wait();

            stopwatch.Start();
            writer.SetValue(new KeyValuePair<string, string>("you", "4")).Wait();
            stopwatch.Stop();
            Console.WriteLine("Time to 4th write {0}", stopwatch.ElapsedMilliseconds);

            Task task1 = readData(reader, cnt, "how", 1);
            Task.Delay(30).Wait();
            Task task2 = readData(reader, cnt, "are", 2);

            task1.Wait();
            task2.Wait();

            stopwatch.Start();
            Task<string> value = reader.GetValue("are", cnt);
            value.Wait();
            Console.WriteLine("\n\n{0}\n\n", value.Result);
            stopwatch.Stop();
            Console.WriteLine("Time to read {0}", stopwatch.ElapsedMilliseconds);
        }

        private static Task readData(IStatefulGrain reader, Context cnt, string find, int id)
        {
            return Task.Run(() =>
            {
                var stopwatch = Stopwatch.StartNew();
                cnt.id = id;
                Task<string> value = reader.GetValue(find, cnt);
                value.Wait();
                Console.WriteLine("\n\n{0}:{1}\n\n", id, value.Result);
                stopwatch.Stop();
                Console.WriteLine("Time to read {0}:{1}", id, stopwatch.ElapsedMilliseconds);
                return 0;
            });
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
