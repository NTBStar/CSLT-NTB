using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CALCULATOR
{
    public class Exc2
    {
        static void Main1(string[] args)
        {
            checked
            {
                Console.Write("Enter the Celsius: ");
                float Celcius = Convert.ToSingle(Console.ReadLine());
                float Kelvin = 273 + Celcius;
                float Farenheit = Celcius * 18 / 10 + 32f;
                Console.WriteLine($"{Celcius} celsius = {Kelvin} K \n{Celcius} celcius = {Farenheit} F");

                Console.Write("Enter the sphere's radius: ");
                float Radius = Convert.ToSingle(Console.ReadLine());
                float pi = 3.14f;
                float Surface = 4 * pi * Radius * Radius;
                float Volume = 4 / 3 * pi * Radius * Radius * Radius;
                Console.WriteLine($"Surface = {Surface} \nVolume = {Volume}");

                Console.WriteLine("Enter two numbers to calculate");
                Console.Write("First num: ");
                byte a = Convert.ToByte(Console.ReadLine());
                Console.Write("Second num: ");
                byte b = Convert.ToByte(Console.ReadLine());
                int c = a + b;
                int d = a - b;
                int e = a * b;
                int f = a / b;
                int g = a % b;
                Console.WriteLine($"{a}+{b}={c} \n {a}-{b}={d} \n {a}x{b}={e} \n {a}/{b}={f} \n {a} mod {b}={g}");



            }
        }
        //Bai_1
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            decimal a, b;
            Console.Write("Nhập số điện cũ: ");
            a = decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập số điện mới: ");
                b = decimal.Parse(Console.ReadLine());
            }
            while (b < a);
        }
        //Bai_2 Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)

    }
}
