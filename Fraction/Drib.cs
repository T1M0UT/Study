using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Fraction
{
    class Drib
    {

        static void Main()
        {
            Init();
            Console.WriteLine();
        }
        static void Init()
        {
            string ss = Console.ReadLine();
            fraction drib1 = new fraction();
            fraction drib2 = new fraction();
            string[] s = ss.Split(' ');
            if (s.Length > 1)
            {
                if (FractionFactory.IsFraction(s[0]))
                {
                    drib1 = FractionFactory.MakeFraction(s[0]);
                }
                if (FractionFactory.IsFraction(s[2]))
                {
                    drib2 = FractionFactory.MakeFraction(s[2]);
                }
                switch (s[1])
                {
                    case "+":
                        (drib1 + drib2).Write();
                        break;
                    case "-":
                        (drib1 - drib2).Write();
                        break;
                    default:
                        Console.WriteLine("Error +/-");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
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
            public static implicit operator fraction(int x)
            {
                fraction qwqwq = new fraction();
                qwqwq.numerator = x;
                qwqwq.denominator = 1;
                return qwqwq;
            }
            public static fraction operator +(fraction first, fraction second)
            {
                fraction first_second = new fraction();
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
            public static fraction operator -(fraction first, fraction second)
            {
                fraction first_second = new fraction();
                if (first.denominator != second.denominator)
                {
                    first_second.denominator = NSK(first.denominator, second.denominator);
                    first_second.numerator = first.numerator * NSK(first.denominator, second.denominator) / first.denominator - second.numerator * NSK(first.denominator, second.denominator) / second.denominator;
                }
                else
                {
                    first_second.denominator = first.denominator;
                    first_second.numerator = first.numerator - second.numerator;
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
        static class FractionFactory
        {
            public static bool IsFraction(string str)
            {
                string[] strArray = str.Split('/');
                if (strArray.Length == 1)
                {
                    bool Parseable3 = int.TryParse(strArray[0], out _);
                    if (Parseable3) return true;
                }
                else if (strArray.Length == 2)
                {
                    bool Parseable1 = int.TryParse(strArray[0], out _);
                    if (Parseable1)
                    {
                        bool Parseable2 = int.TryParse(strArray[1], out _);
                        if (Parseable2) return true;
                    }
                }
                return false;
            }
            public static fraction MakeFraction(string str)
            {
                string[] strArray = str.Split('/');
                fraction temp = new fraction();
                temp.numerator = int.Parse(strArray[0]);
                if (strArray.Length == 1)  temp.denominator = 1;
                else temp.denominator = int.Parse(strArray[1]);
                return temp;
            }
        }
    }
}
