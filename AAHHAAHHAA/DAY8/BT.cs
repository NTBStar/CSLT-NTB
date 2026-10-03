using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY8
{
    public class BT
    {
        static int findLen(string s)
        {
            int k = 0;
            foreach (char c in s) { k++; }
            return k;
        }
        static string individualChar (string s)
        {
            char[] chars = s.ToCharArray();
            Console.WriteLine(string.Join(", ", chars));
            return chars.ToString();
        }
        static int CountWord(string s)
        {
            bool k = false;
            int count = 0;
            foreach (char c in s)
            {
                if (!char.IsWhiteSpace(c))
                {
                    k = true;
                    count++;
                }
            }
            return count;
        }
        static string reverseChar(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(string.Join(", ", chars));
            return chars.ToString();
        }
        static string CompareLen (string s1, string s2)
        {
            int n = findLen(s1);
            int n2 = findLen(s2);
            if (n == n2)  Console.WriteLine("2 day bang nhau"); return s1;
            if (n > n2)   Console.WriteLine("day 1 dai hon"); return s1;
            if (n < n2)  Console.WriteLine("day 2 dai hon"); return s2;
        }
        static int CountChar (string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!sb.ToString().Contains(c))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString().Length;
        }
        static void VowelConsonant (string s, out int n, out int k)
        {
            n = 0;
            k = 0;
            string vowel = "ueoaiUEOAI";
            foreach (char c in s)
            {
                if (vowel.Contains(c))
                {
                    n++;
                }
                else k++;
            }
        }
        static void Main (string[] args)
        {
            string s = "Are you good";
            individualChar(s);
        }
    }
}
