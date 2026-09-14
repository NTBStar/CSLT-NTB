using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY6
{
    public class baitapbuoi6
    {
        static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static int Findmax(int firstNum, params int[]p)
        { 
            int max = firstNum;
            foreach (int i in p)
            {
                if (i > firstNum)
                {
                    max = i;
                }
                firstNum = firstNum;
                
            }
            Console.WriteLine($"{max} là số lớn nhất");
            return max;

        }
        static int facto(int a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial = i * factorial;
                
            }
            Console.WriteLine($"Factorial of your num = {factorial}");
            return factorial;
        }
        static bool isPrime (int a)
        {
            if (a <= 1)
            {
                Console.WriteLine("Nhập số lớn hơn 1");
            }
            else
            {

            }

            return true;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
