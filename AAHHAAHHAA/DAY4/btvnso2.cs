using AAHHAAHHAA.DAY3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace AAHHAAHHAA.DAY4
{
    public class btvnso2
    {
        static void Bai1()
        {
            Console.Write("Enter the number you want to check: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
            Console.Write("num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3 = ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"num1({num1}) is the largest");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"num2({num2}) is the largest");
            }
            else { Console.WriteLine($"num3({num3}) is the largest"); }
        }
        static void Bai2() 
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào 3 cạnh tam giác: ");
            float ab = float.Parse(Console.ReadLine()); 
            float ac = float.Parse(Console.ReadLine()); 
            float bc = float.Parse(Console.ReadLine());
            if (ab + bc > ac && ab + ac>bc && bc+ac > ab)
            {
                if (ab==bc&&ab==ac&&bc==ac)
                {
                    Console.WriteLine("Đây là tam giác đều");
                }
                else if (ab ==ac||ab==bc||bc==ac)
                {
                    Console.WriteLine("Đây là tam giác cân");
                }
                else { Console.WriteLine("Đây là tam giác thường"); }
                
            } 
            else { Console.WriteLine("Đây không phải tam giác"); }
        }
        static void Bai3()
        {
            Console.Write("Nhập tọa độ x = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhập tọa độ y = ");
            double y = double.Parse(Console.ReadLine());
            switch (true)
            {
                case bool when(x > 0 && y > 0):
                    Console.WriteLine("Điểm này nằm trong góc phần tư thứ nhất");
                    break;
                case bool when(x < 0 && y > 0):
                    Console.WriteLine("Điểm này nằm trong góc phần tư thứ hai");
                    break;
                case bool when(x < 0 && y < 0):
                    Console.WriteLine("Điểm này nằm trong góc phần tư thứ ba");
                    break;
                case bool when(x > 0 && y < 0):
                    Console.WriteLine("Điểm này nằm trong góc phần tư thứ tư");
                    break;
                case bool when(x == 0 && y != 0):
                    Console.WriteLine("Điểm này nằm trên trục Oy");
                    break;
                case bool when(x != 0 && y == 0):
                    Console.WriteLine("Điểm này nằm trên trục Ox");
                    break;
                default: Console.WriteLine("Điểm này là gốc tọa độ");
                    break;
                    
            }
        }
            static void Main1(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            Bai3();
            }
    }
}
