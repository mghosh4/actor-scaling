using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWMROrleansGrains
{
    static public class Parameters
    {
        /// <summary>
        /// Take me to your leader lease duration
        /// </summary>
        public static TimeSpan LEASE_DURATION = new TimeSpan(0, 10, 0);

        public static int NUM_REPLICAS = 5;
    }
}
