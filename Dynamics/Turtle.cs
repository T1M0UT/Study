using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtils;

namespace Dynamics
{
    class Turtle
    {
        static void Main()
        {
            int width = 3;   // int.Parse(Console.ReadLine());
            int height = 3;  // int.Parse(Console.ReadLine());
            Fields(width,height);
        }
        static void Fields(int width, int height)
        {
            int[,] Field = new int[width,height];
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Field[i,j]=MyUtils.Rnd.RandIntAB(1,8);
                    Console.Write($"{ Field[i, j],3}");
                }
                Console.WriteLine();
            }
            int[,] ImField = new int[width, height];
            ImField[0, 0] = Field[0, 0];
            for (int j=1; j<height;j++)
            {
                ImField[0, j] = Field[0, j] + ImField[0, j-1];
            }
            for(int i = 1; i < width; i++)
            {
                ImField[i, 0] = Field[i, 0] + ImField[i-1, 0];
            }
            for (int j = 1; j < height; j++)
            {
                for (int i = 1; i < width; i++)
                {
                    int temp = (ImField[i - 1, j]>ImField[i,j-1]? ImField[i - 1, j]: ImField[i, j - 1]) ;
                    ImField[i, j] = temp + Field[i, j];
                    
                }
            }
            //==============================================
            Console.WriteLine();
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    Console.Write($"{ImField[i, j],3}");
                }
                Console.WriteLine();
            }
        }
    }
}
