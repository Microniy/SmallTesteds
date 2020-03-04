using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTesteds
{
   public static class TestedTimes
    {
        public delegate int Method(int N);
        public static string Test001(Method TestedMethod,int N)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            long allTime = 0;
            for(int i=0; i < 10000; i++)
            {
                sw.Start();
                _ = TestedMethod(N);
                sw.Stop();
                allTime += sw.ElapsedMilliseconds;
            }

            return string.Format("{0} - for 10 000 iteration - {1} Milliseconds", TestedMethod.Method.Name, (allTime).ToString());
        }
    }
}
