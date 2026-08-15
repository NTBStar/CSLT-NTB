using System;
using System.ComponentModel.DataAnnotations;
namespace Newbie
{
    class Program
    {
        static void Main(string[] args)
        {
            string enter = "Enter Your Full Name";
            string you = "Hello my friend";
            Console.WriteLine(you);
            string Name = Console.ReadLine();
            Console.WriteLine("You are " + Name);

        }
    }
}