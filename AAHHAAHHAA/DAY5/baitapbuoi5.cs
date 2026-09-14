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
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhập số thứ {i}: ");
                double a = double.Parse(Console.ReadLine());
                b = b + a;
            }
            Console.WriteLine($"sum = {b}");
            Console.WriteLine($"average = {b / 10d}");
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
            if (giatriN > 20)
            {
                Console.WriteLine("Số lớn quá in không nổi");
            }
            else
            {
                Console.Write("Dãy số của bạn: ");
                for (int i = 1; i <= giatriN; i++)
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
            int imperfectNum = int.Parse(Console.ReadLine());
            if (imperfectNum <= 1)
            {
                Console.WriteLine("Vui lòng nhập số lớn hơn 1");
                return;
            }
            int sumUOC = 0;
            string UOC = "";
            for (int i = 1; i <= imperfectNum / 2; i++)
            {
                if (imperfectNum % i == 0)
                {
                    sumUOC = sumUOC + i;
                    if (i == 1)
                    {
                        UOC += $"{i}";
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
            if (notPrime <= 1)
            {
                Console.WriteLine("Vui lòng nhập số nguyên lớn hơn 1");
                return;
            }
            //Xác định số nguyên tố
            bool Primal = true;
            if (notPrime == 2)
            {
                Primal = true;
            }
            else
            {
                for (int i = 2; i <= notPrime / 2 && Primal == true; i++)
                {
                    if (notPrime % i == 0)
                    {
                        Primal = false;
                    }
                }
            }
            switch (Primal)
            {
                case true:
                    Console.WriteLine($"{notPrime} là số nguyên tố");
                    break;
                case false:
                    Console.WriteLine($"{notPrime} không phải số nguyên tố");
                    break;
            }
        }
        static void Bai9()
        {
            //Liệt kê các số nguyên tố bé hơn n
            Console.WriteLine("Nhập giá trị lớn nhất: ");
            int primebelow = int.Parse(Console.ReadLine());
            if (primebelow <= 1) { Console.WriteLine("Vui lòng nhập số lớn hơn 1"); }
            string songuyentoduoiN = "2";
            for (int i = 3; i < primebelow; i++)
            {
                bool Primal2 = true;
                for (int j = 2; j <= i / 2 && Primal2 == true; j++)
                {
                    if (i % j == 0)
                    {
                        Primal2 = false;
                    }
                }
                if (Primal2)
                    songuyentoduoiN += $", {i}";
            }
            Console.Write($"Các số nguyên tố nhỏ hơn {primebelow} là: ");
            Console.WriteLine(songuyentoduoiN);
        }
        static void Bai10 ()
        {
         
        //Liệt kê n số nguyên tố đầu tiên
            Console.WriteLine("Nhập số lượng số nguyên tố cần tìm: ");
            int listprime = int.Parse(Console.ReadLine());
            if (listprime < 1)
            {
                Console.WriteLine("Nhập số lớn hơn");
            }
            List<int> primes = new() { 2 };
            int startNum = 3;
            while (primes.Count < listprime)
            {
                bool Primal3 = true;
                for (int i = 3; i * i <= startNum; i += 2)
                {
                    if (startNum % i == 0)
                    {
                        Primal3 = false;
                        break;
                    }
                }
                if (Primal3)
                { 
                        primes.Add(startNum);
                }
                        startNum += 2;
                
            }
            Console.WriteLine($"{listprime} số nguyên tố đầu tiên là: {string.Join(", ", primes)}");
        }
            static void Main1(string[] args)
            {
            
            }
        
    }
}