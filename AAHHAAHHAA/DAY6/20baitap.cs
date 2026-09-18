using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

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


        static void Main(string[] args)
        {
          
        }
        
    }
}
