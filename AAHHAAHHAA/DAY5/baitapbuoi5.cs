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
                for (int j = 1; j <= i; j++)
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
                    Console.Write($"{1 + hesoK} ");
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

                    Console.Write($"{hesoF + 1} ");
                    hesoF++;
                }

                Console.WriteLine();
            }

        }
        static void Bai6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập giá trị n");
            int giatriN = int.Parse(Console.ReadLine());
            double sumN = 0;
            if (giatriN >20)
            {
                Console.WriteLine("Số lớn quá in không nổi");
            }
            else 
            {
                Console.Write("Dãy số của bạn: ");
                for (int i = 1;i <= giatriN;i++)
                {
                    sumN = sumN + ((double)1 / (double)i);
                    Console.Write($"1/{i} ");
                        if (i < giatriN)
                        {
                        Console.Write("+ ");
                        }
                    
                }
            }
            Console.WriteLine($"Tổng của dãy này bằng: {sumN:F5}");
        }
        static void Bai7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số cần kiểm tra: ");
            int imperfectNum=int.Parse(Console.ReadLine());
            if (imperfectNum <=1)
            {
                Console.WriteLine("Vui lòng nhập số lớn hơn 1");
                return;
            }
            int sumUOC = 0;
            string UOC = "";
            for (int i = 1;i  <= imperfectNum/2;i++)
            {
                if (imperfectNum%i==0)
                {
                    sumUOC = sumUOC + i;
                    if (i==1)
                    {
                        UOC+=$"{i}";
                    }
                    else
                    {
                    UOC += $"+{i}";
                    }
                }
                
            }
            if (sumUOC == imperfectNum)
            {
                Console.WriteLine($"{imperfectNum} là số hoàn hảo!");
                Console.WriteLine($"{UOC} = {imperfectNum}");
            }
            else { Console.WriteLine($"{imperfectNum} không phải số hoàn hảo"); }
 
        }
        static void Bai8()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số cần kiểm tra");
            int notPrime = int.Parse(Console.ReadLine());
            if (notPrime <=1)
            {
                Console.WriteLine("Vui lòng nhập số nguyên lớn hơn 1");
                return;
            }
            for (int i = 1;i<= notPrime/2;i++)
            {
                if (notPrime%i==0)
                {
                    Console.WriteLine($"{notPrime} không phải số nguyên tố");
                }
            }

        }
        static void Main(string[] args)
        {
         
        }
    }
}
