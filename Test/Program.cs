using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static long n=40;
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(n));

        }
        public static long[] Cache = new long[n];
        static long Fibonachi(long n)
        {
            if (n < 2) return n;
            {
                if (Cache[n] != 0)
                {
                    return Cache[n];
                }
                Cache[n]=Fibonachi(n - 1) + Fibonachi(n - 2);
                return Cache[n];
            }
        }
    }
}
