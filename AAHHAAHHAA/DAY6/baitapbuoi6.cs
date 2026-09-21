using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AAHHAAHHAA.DAY6
{
    public class baitapbuoi6
    {
        static int FindMax(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        static int Findmax(int firstNum, params int[]p)
        { 
            int max = firstNum;
            foreach (int i in p)
            {
                if (i > firstNum)
                {
                    max = i;
                }
                firstNum = firstNum;
                
            }
            Console.WriteLine($"{max} là số lớn nhất");
            return max;

        }
        static int facto(int a)
        {
            int factorial = 1;
            for (int i = 1; i <= a; i++)
            {
                factorial = i * factorial;
                
            }
            return factorial;
        }
        static bool isPrime (int a) //Tìm prime
        {
            if (a <= 1) { return false;}
            if (a == 2) { return true; }
            if (a%2 == 0) { return false;}
            else
            {
                for (int i = 3; i*i <= a; i++)
                {
                    if (a%i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        static string primeUnder (int a) //Tìm prime bé hơn N
        {
            string listprime = "2";
            if (a < 2)
            {
                Console.WriteLine("Nhập số lớn hơn");
                return "";
            }
            if (a == 2) { return "2"; }
            else
            {
               for (int j = 3; j < a; j+=2)
                {
                    if (isPrime (j))
                    {
                        listprime += $", {j}";
                    }
                }
                return listprime;
            }
          
        }
        static string Nprime (int a) //Tìm n prime đầu tiên
        {
            if (a < 1) return "";
            if (a == 1) return "2";
                string listprime2 = "2";;
            if (a>1)
            {
                int startNum = 3;
                int count = 1;
                while (count<=a-1)
                {
                    if (isPrime (startNum))
                    {
                        listprime2 += $", {startNum}";
                        count++;
                    }
                    startNum += 2;
                }
            }
            return listprime2;
        }
        static bool checkPerfect (int a)
        {
            if (a<=1) return false;
            int Uoc = 1;
               for ( int j = 2; j*j < a; j++)
                {
                    if (a%j==0)
                    {
                       Uoc += j;
                        if (j*j != a)
                        {
                        Uoc += a / j;
                        }
                    }
                }
          return a == Uoc;
        }
        static string listPerfect (int a)
        {
            List<int> result = new List<int>();
            for ( int i = 2; i < a;i+=2)
            {
                if (checkPerfect (i))
                {
                    result.Add(i);
                }
            }
            return string.Join (",", result);
        }
        static bool checkPangrams (string input)
        {
            string lowerinput = input.ToLower();
            for (char c = 'a'; c <= 'z';c++)
            {
                if (!lowerinput.Contains (c)) 
                {  
                    return false; 
                }
            } 
            return true;
        }
        static string SapXepTangDan(int[] arr)
        {
            Array.Sort (arr);
            string result = string.Join(", ", arr);
            return result;
        }
        static void Main1(string[] args)
        {

        }
    }
}
