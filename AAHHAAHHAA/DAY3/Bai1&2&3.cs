using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;

namespace AAHHAAHHAA.DAY3
{
    enum CurrencyType
    {
        USD,
        EUR,
        JPY,
        GBP
    }
    class Bai1
    {
        static void Bai_01()
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
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + (tieuThu - 200) * 2729;
            else
                tienDien = 50 * 1806 + 50 * 1866 + 100 * 2167 + 200 * 2729 + (tieuThu - 300) * 3050;
            decimal thueVAT = (tienDien * 0.08m);
            Console.WriteLine($"Số điện tiêu thụ: {tieuThu:N0} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien:N0} VNĐ");
            Console.WriteLine($"Thuế VAT (8%): {thueVAT:N0} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tienDien + thueVAT:N0} VNĐ");
        }
        static void Bai_02()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhap vao chieu cao (met): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao can nang (kg): ");
            double weight = double.Parse(Console.ReadLine());
            double Bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"Chỉ số BMI của bạn: {Bmi:F2}");
            if (Bmi < 18.5)
            {
                Console.WriteLine("Phân loại sức khỏe: Gầy (thiếu cân)");
            }
            else
            {
                if (Bmi < 23)
                {
                    Console.WriteLine("Phân loại sức khỏe: Bình thường (lý tưởng)");
                }
                else
                {
                    if (Bmi < 25)
                    {
                        Console.WriteLine("Phân loại sức khỏe: Thừa cân (tiền béo phì)");
                    }
                    else { Console.WriteLine("Phân loại sức khỏe: Béo phì"); }
                }

            }
            double maxweight = 22.9 * Math.Pow(height, 2);
            double minweight = 18.5 * Math.Pow(height, 2);
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {minweight:F2} kg đến {maxweight:F2} kg");
        }
        static void Bai_03()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhập số tiền VNĐ: ");
            decimal tienquydoi = decimal.Parse(Console.ReadLine());
            decimal usdrate = 25400m;
            decimal eurrate = 27200m;
            decimal jpyrate = 165m;
            decimal gbprate = 32100m;
            decimal tiensauquydoi = 0;
            decimal cost = tienquydoi * 0.005m;
            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            byte phanloai = byte.Parse(Console.ReadLine());
            string type = "";
            CultureInfo culture = null;
            switch (phanloai)
            {
                case 1:
                    type = "USD";
                    culture = new CultureInfo("en-US");
                    tiensauquydoi = (tienquydoi-cost) / usdrate;
                    break;
                case 2: 
                    type = "EUR";
                    culture = new CultureInfo("fr-FR");
                    tiensauquydoi = (tienquydoi-cost) / eurrate;
                    break;
                case 3: 
                    type = "JPY";
                    culture = new CultureInfo("ja-JP");
                    tiensauquydoi = (tienquydoi-cost) / jpyrate;
                    break;
                case 4: 
                    type = "GBP";
                    culture = new CultureInfo("en-GB");
                    tiensauquydoi = (tienquydoi-cost) / gbprate;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ");
                    return;
            }
            Console.WriteLine($"Phí dịch vụ (0.5%): {cost:N2}");
            Console.WriteLine($"Số tiền VNĐ tính đổi: {(tienquydoi-cost):N2}");
            Console.WriteLine($"Số tiền {type} nhận được: {tiensauquydoi.ToString("C2",culture)}");
        } 

        static void Main1(string[] args)
        {
        Bai_03();

        }
    }
}
   