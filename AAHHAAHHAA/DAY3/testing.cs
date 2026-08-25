using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.ExceptionServices;
using System.Text;

namespace CALCULATOR
{
    public class testing
    {
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
