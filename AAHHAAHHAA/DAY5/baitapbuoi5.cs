using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY5
{
   class baitapbuoi5
    {
        static void Bai2()
        {
            //Write a program to read 10 numbers and find their average and sum
            Console.OutputEncoding = Encoding.UTF8;
            double b = 0;
            for (int i = 1; i <=10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                double a = double.Parse(Console.ReadLine());
                b = b + a;
            }
            Console.WriteLine($"sum = {b}");
            Console.WriteLine($"average = {b/10d}");
        }
        static void Bai3()
        {
            //Write a program to display the multiplication table of a given integer.
            for (int i = 2; i <= 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}*{j}={i * j}");
                }
                Console.WriteLine();
            }
        }
        static void Bai4()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1;j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            int hesoK = 0;
            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{1+hesoK} ");
                    hesoK++;
                    
                }
                Console.WriteLine();
            }
            int hesoF = 0;
            for (int i = 1; i <= 4; i++)
            {
                Console.Write(new string(' ', 5 - i));
                for (int j = 1; j <= i; j++)
                {

                    Console.Write($"{hesoF+1} ");
                    hesoF++;
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Bai4();
        }
    }
}
