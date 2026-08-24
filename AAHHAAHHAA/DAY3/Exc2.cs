using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        static void Main2(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
            decimal a, b;
            Console.Write("Nhập số điện cũ: ");
            a = decimal.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhập số điện mới: ");
                b = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Sdm phải lớn hơn hoặc bằng sdc");
            }
            while (b < a);
            decimal tieuThu = b - a;
            decimal tienDien = 0;
            if
                (tieuThu <= 50)
                tienDien = tieuThu * 1806;
                else if (tieuThu <= 100)
                tienDien = 50 * 1806 + (tieuThu - 50) * 1866;
                else if (tieuThu <= 200)
                tienDien = 50 * 1806 + 50 * 1866 + (tieuThu - 100) * 2167;
                else if (tieuThu <= 300)
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (tieuThu-200)*2729;
            else 
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 200*2729 + (tieuThu-300)*3050;
            decimal thueVAT = (tienDien * 0.08m);
            Console.WriteLine($"Số điện tiêu thụ: {tieuThu:N0} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tienDien+thueVAT:N0} VNĐ");

        }
        //Bai_2 Tính Tiền Điện Sinh Hoạt Gia Đình Theo Bậc Thang(EVN)

    }
}
