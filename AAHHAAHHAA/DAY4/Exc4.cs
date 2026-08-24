using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY4
{
    class Exc4
    {
        public static void Main4(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a}+{b} = {a+b}");
            Console.WriteLine($"{a}-{b} = {a-b}");
            Console.WriteLine($"{a}*{b} = {a*b}");
            Console.WriteLine($"{a}/{b} = {a/b}");
            Console.WriteLine($"{a}%{b} = {a%b}");

            double x;
            Console.Write("Nhập y = ");
            int y = int.Parse(Console.ReadLine());
            if (y >= -5 && y <= 5)
            {
                x = y * y + 2 * y + 1;
                Console.WriteLine($"x = {x}");
            }

            else
                Console.WriteLine("Nhập lại y khác");


            Console.Write("Nhập quãng đường (đơn vị mét): ");
            float diStance = float.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian (đơn vị giờ):  ");
            float HouR = float.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian (đơn vị phút):  ");
            float MinutE = float.Parse(Console.ReadLine());
            Console.Write("Nhập thời gian (đơn vị giây):  ");
            float SeconD = float.Parse(Console.ReadLine());
            float SumTime = HouR + MinutE / 60f + SeconD / 3600f;
            float Kilometer = diStance / 1000f;
            float Miles = diStance / 1609.344f;
            Console.WriteLine($"{diStance} meter = {Kilometer} km");
            Console.WriteLine($"{diStance} meter = {Miles} mile");
            float speed1 = Kilometer / SumTime;
            float speed2 = Miles / SumTime;
            Console.WriteLine($"Speed in kilometers per hour = {speed1} km/h");
            Console.WriteLine($"Speed in miles per hour = {speed2} mile/h");

            Console.Write("Enter the sphere's radius: ");
            float Radius = Convert.ToSingle(Console.ReadLine());
            float pi = 3.14f;
            float Surface = 4 * pi * Radius * Radius;
            float Volume = 4 / 3 * pi * Radius * Radius * Radius;
            Console.WriteLine($"Surface = {Surface} \nVolume = {Volume}");

            Console.Write("Nhập 1 kí tự để bắt đầu phân loại: ");
            char inputChar = Convert.ToChar(Console.ReadLine());
            if ( "ueoaiyUEOAIY".Contains( inputChar ) )
            {
                Console.WriteLine($"{inputChar} is Vowel");
            } 
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} is digit");
            }
            else Console.WriteLine($"{inputChar} is Symbol");

        }

    }
}
       
