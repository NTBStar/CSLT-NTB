using System;
using System.Collections.Generic;
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
        static void Main(string[] args)
        {

        }
        
    }
}
