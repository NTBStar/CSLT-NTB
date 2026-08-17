using System;
using System.ComponentModel.DataAnnotations;
namespace Newbie
{
    class Exc1
    {
        static void Main(string[] args)
        {
            string enter = "Enter Your Full Name: ";
            Console.Write(enter);
            string Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello " + Name);
            
            
            
            string Enter = "Enter your num: ";
            Console.WriteLine(Enter);
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //to Add / Sum Two Numbers
            int SumS = a + b;
            Console.WriteLine(SumS);

            //to Swap Values of Two Variables
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a la " + Convert.ToString(a));
            Console.WriteLine("b la " + Convert.ToString(b));

            // to Multiply two Floating Point Numbers
            float so3 = 7.5f;
            float so4 = 8.82f;
            float Multi = so3 * so4;
            Console.WriteLine($"{so3}*{so4}={MathF.Round(Multi,2)}");

            //to convert feet to meter
            float so3met = so3 * 0.3048f;
            Console.WriteLine($"{so3} feet = {MathF.Round(so3met,2)} metter");

            //to convert Celsius to Fahrenheit and vice versa
            float tempC1 = 45;
            float tempF1 = tempC1 * 1.8f + 32;
            float tempF2 = 100;
            float tempC2 = (tempF2 - 32) / 1.8f;
            Console.WriteLine($"{tempC1}-C = {tempF1}F");
            Console.WriteLine($"{tempF2}F = {tempC2}-C");

            //to find the Size of data types
            Console.WriteLine("Size of double is: " + sizeof(double));

            //to Print ASCII Value (tip: read character, print number of this char) 
        }
    }
}