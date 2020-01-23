using System;
    class ab
{
    static void Main()
    {
      int N=int.Parse(Console.ReadLine());
      string[] Arr = Console.ReadLine().Split(' ');
        int[] IntArr = new int[N];
        int min = 300,max = 0,five=0,three=0,one=0;
        for(int i = 0; i < N; i++)
        {
            IntArr[i] = int.Parse(Arr[i]);
            min = (IntArr[i]<min? IntArr[i]:min);
            max = (IntArr[i]>max? IntArr[i]:max);
        }
        for (int i = 0, j = N; i < N; i++, j--)
        {






            if (five == N)
            {
                Console.WriteLine("1");
                break;
            }
            if (three == N)
            {
                Console.WriteLine("2");
                break;
            }
            if (one == N)
            {
                Console.WriteLine("3");
                break;
            }
        }
    }
}