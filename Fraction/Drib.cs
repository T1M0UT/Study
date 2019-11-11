using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Drib
    {
        static void Main()
        {
            int n1 = 3;
            int d1 = 4;
            int n2 = 4;
            int d2 = 8;
            fraction first = new fraction();
            fraction second = new fraction();
            first.numerator = n1;
            first.denominator = d1;
            first.Write();
            Console.Write(" + ");
            second.numerator = n2;
            second.denominator = d2;
            second.Write();
            Console.Write(" = ");
            (first + second).Write();
            Console.WriteLine();
        }
        //===============================================================================
        struct fraction
        {
            public int numerator;
            public int denominator;
            public void Write()
            {
                Console.Write(numerator + "/" + denominator);
            }
            public static fraction operator +(fraction first, fraction second)
            {
                fraction first_second;
                if (first.denominator != second.denominator)
                {
                    first_second.denominator = NSK(first.denominator, second.denominator);
                    first_second.numerator = first.numerator * NSK(first.denominator, second.denominator) / first.denominator + second.numerator * NSK(first.denominator, second.denominator) / second.denominator;
                }
                else
                {
                    first_second.denominator = first.denominator;
                    first_second.numerator = first.numerator + second.numerator;
                }
                int temp_NSD = NSD(first_second.numerator, first_second.denominator);
                first_second.numerator /= temp_NSD;
                first_second.denominator /= temp_NSD;
                return first_second;
            }
            static int NSK(int m, int n)
            {
                return (m * n) / NSD(m, n);
            }
            static int NSD(int a, int b)
            {
                while (a != 0 && b != 0)
                {
                    if (a > b)
                    {
                        a %= b;
                    }
                    else b %= a;
                }
                return a + b;
            }

        }
    }
}
