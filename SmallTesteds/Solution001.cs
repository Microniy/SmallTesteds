using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallTesteds
{
   public static class Solution001
    {
        public static int SolutionV1(int N)
        {
            string result = "";
            int MaxLength = 0;
            while (N > 0)
            {
                int remainder = N % 2;
                result = remainder.ToString() + result;
                N /= 2;
            }

            if (result != "")
            {
                string[] strArr = result.Split('1');
                if (strArr.Length > 2)
                {
                    foreach (string str in strArr)
                    {
                        if (str.Length > MaxLength)
                            MaxLength = str.Length;
                    }
                }
            }
            return MaxLength;
        }
        public static int SolutionV2(int N)
        {
            int MaxLength =0;
            
            string strArray = Convert.ToString(N, 2);
            int count = 0;
            bool beginCounter = false;
            foreach(char bit in strArray)
            {
                if(bit == '1')
                {
                    if (MaxLength < count) { MaxLength = count; }
                    count = 0;
                    beginCounter = true;
                }
                else
                {
                    if (beginCounter) { count++; }
                }
            }
            return MaxLength;
        }
    }
}
