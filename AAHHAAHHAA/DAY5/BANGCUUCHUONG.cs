using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY5
{
    public class BANGCUUCHUONG
    {
        static void Baitapvonglap()
        {
            for (int i = 2; i <=4; i++)
            {
                for (int j = 1;j<=10;j++)
                {
                    Console.WriteLine($"{i}*{j}={i*j}");
                }
                Console.WriteLine();
            }
            for (int i = 1;i <=5;i++)
            {
                for(int j = 1; j<=i;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <=6;i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("0 ");
                    }
                    else { Console.Write("1 "); }
                }
                Console.WriteLine();
            }
        }
        static void Main1(string[] args)
        {

        }

    }
}
