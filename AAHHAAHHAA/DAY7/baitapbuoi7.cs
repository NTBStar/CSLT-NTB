using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY7
{
    internal class baitapbuoi7
    {
        static int[] nhap_mang()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            return arr;
        }
        static void gangiatriRandom (int[] arr)
        {
            Random element = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = element.Next(1,10); 
            }
        }
        static void in_arr (int[] arr)
        {
            string n = string.Join(", ", arr);
            Console.WriteLine(n);
            //foreach (int i in arr)
            //{
            //    Console.Write($"{i}, ");
            //}
            Console.WriteLine();
            return;
        }
        static void thay_chan_bang_0(int[] arr)
        {
            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i] %2==0)
                {
                    arr[i] = 0;
                }
                if (i<arr.Length-1)
                {
                    Console.Write($"{arr[i]}, ");
                }
                else { Console.Write($"{arr[i]}"); }
            }
            return;
        }
        static void CalculateAverage (int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum+= i;
            }
            float average = sum/arr.Length;
        }
        static bool TestValue (int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==x)
                {
                    return true;
                }
            }
            return false;
        }
        static int FindIndex (int[] arr, int x)
        {
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i]==x) 
                {
                    return i;
                }
            }
            return -1;
        }
        static void ReplaceSwap(int[]arr,int x)
        {
            while (x<arr.Length-1)
            {
                arr[x] = arr[x+1];
                x++;
            }
            return;
        }
        static int[] RemoveElement (int[] arr, int x)
        {
                    ReplaceSwap(arr, x);
            int[] temp = new int[arr.Length-1];
            for (int i = 0;i<temp.Length;i++)
            {
                temp[i] = arr[i];
            }
            return temp;
        }

        static void Main(string[] args)
        {
            int[] mang = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            in_arr(mang);
            int vitritimthay = FindIndex(mang, 4);
            int[] result = RemoveElement(mang, vitritimthay);
            in_arr(result);

        }
    }
}
