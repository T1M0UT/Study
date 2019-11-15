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
            fraction first = new fraction();
            fraction second = new fraction();
            string s = Console.ReadLine();
            Regex regex = new Regex(@"(\w*)/(\w*)");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0)
            {
                for(int i=0;i<matches.Count;i++)
                //foreach (Match match in matches)
                {
                    string[] abc = (matches[0].Value).Split('/');

                    first.numerator = int.Parse(abc[0]);
                    first.denominator = int.Parse(abc[1]);
                    string[] bcd = (matches[1].Value).Split('/');
                    second.numerator = int.Parse(bcd[0]);
                    second.denominator = int.Parse(bcd[1]);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
            string[] FindZnak = s.Split(' ');
            if (FindZnak.Length > 0)
            {
                foreach (string x in FindZnak) 
                {
                    switch (x)
                    {
                        case "+":
                            first.Write();
                            Console.Write(" + ");
                            second.Write();
                            Console.Write(" = ");
                            (first + second).Write();
                            Console.WriteLine();
                            break;
                        case "-":
                            first.Write();
                            Console.Write(" - ");
                            second.Write();
                            Console.Write(" = ");
                            (first - second).Write();
                            Console.WriteLine();
                            break;
                        default:
                            break;
                            
                    }
                }
            }
            else
            {
                Console.WriteLine("SMTH WENT WRONG");
            }
        }

        //===============================================================================
        struct fraction
        {
            public fraction(int Numerator, int Denominator)
            {
                numerator = Numerator;
                denominator = Denominator;
            } 
            public int numerator { get; set; }
            public int denominator { get; set; }
            public void Write()
            {
                Console.Write(numerator + "/" + denominator);
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
    }
}
