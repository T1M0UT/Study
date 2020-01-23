using System;

namespace MyUtils
{
    public class MyUtils
    {

    }
    //-------------------------------------------------------------------------------
    public static class Rnd
    {
        private static Random R;
        //==============================================
        public static int RandInt100()
        {
            if (R == null) R = new Random();
            return R.Next(1, 100);
        }
        //==============================================
        public static int RandIntAB(int A, int B)
        {
            if (R == null) R = new Random();
            return R.Next(A, B);
        }
        //==============================================
        public static double RandDoubleAB(this double min, double max)
        {
            if (R == null) R = new Random();
            return Math.Round(R.NextDouble(), 2) * (max - min) + min;
        }
        //==============================================
        public static double RandDouble100()
        {
            if (R == null) R = new Random();
            return Math.Round(R.NextDouble(), 2) * 99 + 1;
        }
        //==============================================
    }
    //--------------------------------------------------------------------------------
    public static class Gen
    {
        public static int[] ArrayIntAB(int a, int b, int Lenght)
        {
            int[] A = new int[Lenght];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandIntAB(a, b);
            }
            return A;
        }
        //==============================================
        public static int[] ArrayInt100(int Lenght)
        {
            int[] A = new int[Lenght];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandInt100();
            }
            return A;
        }
        //==============================================
        public static double[] ArrayDoubleAB(double a, double b, int Lenght)
        {
            double[] A = new double[Lenght];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandDoubleAB(a, b);
            }
            return A;
        }
        //==============================================
        public static double[] ArrayDouble100(int Lenght)
        {
            double[] A = new double[Lenght];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Rnd.RandDouble100();
            }
            return A;
        }
    }
    //--------------------------------------------------------------------------------
    public static class Output
    {
        //==============================================
        public static void WriteLine<T>(this T[] A)
        {
            if (A == null) return;
            foreach (var x in A) Console.Write(x + " ");
        }
        //==============================================
    }
}