using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Schema;

namespace AAHHAAHHAA.DAY6
{
    public class btvn
    {
        static int TinhTong(int a, int b) //TinhTong
        {
            int tinhtong = a + b;
            return tinhtong;
        }
        static bool KiemTraChan(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static int TimMax (int a, int b, int c)
        {
            int max = Math.Max(a, b);
            max = Math.Max(max, c);
            return max;
        }
        static long TinhGiaiThua (int n)
        {
            long factorial = 1;
            for (int i = 1;i<=n;i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static string DaoNguocChuoi (string input)
        {
            if (string.IsNullOrEmpty(input)) return input;
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string (charArray);
        }
        static bool KiemTraNguyenTo (int n)
        {
            if (n <= 1) return false;
            if ((n % 2) == 0) { return false; }
            for (int i = 3;i*i <=n;i++)
            {
                if ((n % i) == 0)
                    return false;
            }
            return true;
        }
        static void InFibbonacci (int n)
        {
            int[] listFib = new int[n];
            listFib[0] = 0;
            listFib[1] = 1;
            if (n <= 1) return;
            if (n == 2) Console.WriteLine("0, 1"); 
            for (int i = 2;i<n;i++)
            {
                listFib[i] = listFib[i - 2] + listFib[i-1];
            }
            Console.WriteLine(string.Join(' ',listFib));
        }
        static int DemNguyenAm(string s)
        {
            int a = 0;
            if (string.IsNullOrEmpty(s)) return 0;
            string NguyenAm = "ueoaiUEOAI";
            foreach (char c in s)
            {
                if (NguyenAm.Contains(c)) { a++; }
                 
            }
            return a;
        }
        static double TinhLuyThua(double x, int y)
        {
            double ketqua = 1;
            if (y == 0) return 1;
            if (y == 1) return x;
            for (int i = 1; i <= y; i++)
            {
                ketqua = ketqua * x;
            }
            Console.WriteLine(ketqua);
            return ketqua;
        }
        static double TinhTrungBinh(int[]arr)
        {
            double Tong = 0;
            double count = 0;
            foreach (int val in arr)
            {
                Tong += val;
                count++;
            }
            Console.WriteLine($"Trung binh cua day nay la: {Tong/count}");
            return Tong/count;
        }
        static bool  KiemTraDoiXung (string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            if (s == new string(charArray)) return true;
            return false;
        }
        static double CelciusToFarenheit (double c)
        {
            return (c * 1.8) + 32;
        }
        static int TimMin(int[] arr)
        {
            int MinNum = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < MinNum) { MinNum = arr[i]; }
            }
            return MinNum;
        }
        static int TongCacChuSo (int n)
        {
            int tong = 0;
            string numchar = Convert.ToString(n);
            foreach (char c in numchar)
            {
                tong += c - '0';
            }
            return tong;
        }
        static void SapXepMangTangDan(int[] arr)
        {
            int change = arr[0];
            for (int j = 1; j <= arr.Length; j++)
            {

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] >= arr[i + 1])
                    {
                        change = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = change;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",arr));
            return;
        }
        static void SapXepMangGíamDan(int[] arr)
        {
            int change = arr[arr.Length-1];
            for (int j = 1; j <= arr.Length; j++)
            {

                for (int i = arr.Length-1; i > 0; i--)
                {
                    if (arr[i] >= arr[i - 1])
                    {
                        change = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = change;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", arr));
            return;
        }
        static string XoaTrungLap (string s)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = s.ToCharArray();
            foreach (char c in arr)
            {
                if (!sb.ToString().Contains(c))
                {
                   sb.Append(c);
                }
            }
            return sb.ToString();
        }
        static int UCLN (int a, int b)
        {
            int c = 1;
            int sodu = 0;
            do
            {
                sodu = a % b;
                a = b;
                b = sodu;
            }
            while (a%b != 0);
            return sodu;
        }
        static string DecimalToBinary (int n)
        {
            StringBuilder sodu = new StringBuilder();
            if (n == 0) 
            { 
                sodu.Append("0"); 
            Console.WriteLine(sodu.ToString());
                return sodu.ToString(); 
            }
            if (n == 1) 
            {
                sodu.Append("1"); 
            Console.WriteLine(sodu.ToString());
                return sodu.ToString(); 
            }
            int thuong = (n - (n % 2)) / 2;
            int lastNum = n % 2;
            sodu.Append(lastNum);
            do
            {
                lastNum = thuong % 2;
                thuong = thuong / 2;
                sodu.Append(lastNum);
            } while (thuong !=0);
            char[] Binary = sodu.ToString().ToCharArray();
            Array.Reverse(Binary);
            string result = new string(Binary);
            Console.WriteLine(result);
            return result;
        }
        static bool KiemTraNamNhuan (int year)
        {
            if (year%400==0 && year%4==0)
            {
                return true;
            }
            else if (year%4==0 && year%100!=0)
            {
                return true;
            }
            return false;
        }
        static int DemSoTu (string sentence)
        {
            int count = 0;
            if (string.IsNullOrWhiteSpace(sentence)) return 0;
            char [] Chars = sentence.ToCharArray();
            bool NewWord = false;
            foreach (char ch in Chars)
            {
                if (!char.IsWhiteSpace(ch))
                {
                    if (!NewWord)
                    {
                    count++;
                    NewWord = true;
                    }
                }
                else
                {
                    NewWord = false;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            string sentence = "Học lập trình C# rất thú vị";
            Console.WriteLine(DemSoTu(sentence));
        }
    }
}
