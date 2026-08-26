using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AAHHAAHHAA.DAY3
{
    class Bai2
    {
        static void Bai_04()
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            DateTime birthday;
            bool OK = DateTime.TryParseExact
                (input, "dd/MM/yyyy", 
                 CultureInfo.InvariantCulture,
                 DateTimeStyles.None,
                 out birthday);
            if (!OK)
            {
                Console.WriteLine("Nhập sai định dạng!");
                return;
            }
            DateTime homnay = DateTime.Now.Date;
            int age = homnay.Year - birthday.Year;
            if (homnay < birthday.AddYears(age))
            {
                age--;
            }
            TimeSpan lived = homnay - birthday;
            double daylived = lived.TotalDays;
            DateTime nextbirthday = new DateTime
                (
                    homnay.Year,
                    birthday.Month,
                    birthday.Day

                );
            if (nextbirthday < homnay)
            {
                nextbirthday = nextbirthday.AddYears (1);
            }
            TimeSpan remainingdays = nextbirthday - homnay;
            int daysleft = remainingdays.Days;


            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {(int)daylived} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysleft} ngày nữa");

        }
        static void Bai_05()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Write($"Số tín môn Lập trình C#: ");
            int mon1 = int.Parse(Console.ReadLine());
            Console.Write($"Số tín môn Toán rời rạc: ");
            int mon2 = int.Parse(Console.ReadLine());
            Console.Write($"Số tín môn Tiếng Anh: ");
            int mon3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm số thang 10");
            Console.Write($"C# ({mon1}TC): ");
            double point1 = double.Parse(Console.ReadLine());
            Console.Write($"Toán ({mon2}TC): ");
            double point2 = double.Parse(Console.ReadLine());
            Console.Write($"Tiếng Anh ({mon3}TC): ");
            double point3 = double.Parse(Console.ReadLine());
            double scoreAVG = (point1 * mon1 + point2 * mon2 + point3 * mon3) / (mon1 + mon2 + mon3);
            
            double GPA;
            char diemchu;
            string hocluc;
            if (scoreAVG < 4)
            {
                GPA = 0;
                diemchu = 'F';
                hocluc = "Kém (Trượt)";
            }
            else
            {
                if (scoreAVG <= 5.4)
                {
                    GPA = 1;
                    diemchu = 'D';
                    hocluc = "Yếu";
                }
                else
                {
                    if (scoreAVG <=6.9)
                    {
                        GPA = 2;
                        diemchu = 'C';
                        hocluc = "Trung bình";
                    }
                    else
                    {
                        if (scoreAVG <=8.4)
                        {
                            GPA = 3;
                            diemchu = 'B';
                            hocluc = "Khá";
                        }
                        else
                        {
                            GPA = 4;
                            diemchu = 'A';
                            hocluc = "Xuất sắc/Giỏi";
                        }
                    }
                }
                    
            }
            Console.WriteLine($"Điểm TB thang 10: {scoreAVG}");
            Console.WriteLine($"Điểm chữ quy đổi: {diemchu}");
            Console.WriteLine($"Điểm GPA thang 4: {GPA}");
            Console.WriteLine($"Xếp loại học lực: {hocluc}");

        }
        static void Bai_06()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập đầy đủ họ tên: ");
            string fullname = Console.ReadLine();
            string fullnameaftertrim = fullname.Trim().ToLower();

            string[] parts = fullnameaftertrim.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length; i++)
            {
                parts [i] = parts[i].Substring(0,1).ToUpper() + parts [i].Substring(1);
            }
            string fixedname = string.Join(" ", parts);
            string ho = parts[0];
            string ten = parts[parts.Length-1];
            string tendem = "";
            for (int u = 1; u < parts.Length-1; u++)
            {
                tendem += parts[u] + " ";
            }
           string tendemaftertrim = tendem.Trim();
            string hokhongdau = RemoveDiacritics[ho];
            Console.WriteLine($"Họ tên chuẩn hóa: {fixedname}");
            Console.WriteLine($"Họ: {ho}");
            Console.WriteLine($"Tên đệm: {tendemaftertrim}");
            Console.WriteLine($"Họ: {ten}");
        }
        public static void Main(string[] args)
        {
            Bai_06();
        }
    }
}
