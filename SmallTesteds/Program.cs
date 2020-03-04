using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTesteds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TestedTimes.Test001( Solution001.SolutionV1,2000));
            Console.WriteLine(TestedTimes.Test001(Solution001.SolutionV2, 2000));
            Console.ReadLine();
        }
    }
}
