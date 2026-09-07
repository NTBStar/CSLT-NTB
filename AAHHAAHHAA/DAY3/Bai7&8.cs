using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY3
{
    internal class Bai7
    {
        static void Bai_07()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Quãng đường (km): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Mức tiêu hao (L/100km): ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Giá xăng (VNĐ/Lít): ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.Write("Số người đi: ");
            int d = byte.Parse(Console.ReadLine());
            double tieuthu = a * b / 100;
            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tieuthu} lít");
            decimal chiphi = (decimal)tieuthu * c;
            Console.WriteLine($"Tổng chi phí xăng dầu: {chiphi} VNĐ");
            decimal chiatien = chiphi / (decimal)d;
            Console.WriteLine($"Chi phí mỗi người: {Math.Ceiling(chiatien/1000)*1000} VNĐ");
        }
        static void Bai_08()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhấn Enter để nhận mã OTP");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) 
            {
                //Phải nhấn đúng phím enter
            }
            Random randomOTP = new Random();
            string verifyOTP = randomOTP.Next(100000, 999999).ToString();
            DateTime creationTime = DateTime.Now;
            Console.WriteLine($"Mã OTP của bạn: {randomOTP}");


        }
        static void Main1(string[] args)
        {
            
        }
    }
}
