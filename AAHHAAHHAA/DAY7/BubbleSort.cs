using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace AAHHAAHHAA.DAY7
{
    public class BubbleSort
    {
        static int[] Nhap10so ()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập phần tử số {i} (enter sau mỗi lần nhập): ");
                int n = int.Parse(Console.ReadLine());
                arr[i] = n;
            }
            Console.WriteLine();
            return arr;
        }
        static void PrintArray (int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }
        static void Swap (int a, int b)
        {
            int temp = a;
            a = b;
            b= temp;
            return;
        }
        static int[] BubbleSortZ(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length-1; i++) //Xếp tăng dần
            {
                if (arr[i] > arr[i + 1]);
            }
            return arr;
                
           
        }
        static void Main(string[] args)
        {
            int[] arr = Nhap10so();
            PrintArray(arr);
        }
    }
}
