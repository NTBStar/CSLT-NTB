using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace AAHHAAHHAA.DAY7
{
    public class BubbleSort
    {
        static int[] Nhap10so()
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
        static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return;
        }
        static int[] BubbleSortZ(int[] arr)
        {
            for (int j = 0; j < arr.Length; j++)
            {

                for (int i = 0; i < arr.Length - 1; i++) //Xếp tăng dần
                {
                    if (arr[i] > arr[i + 1])
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }
            return arr;
        }
        static int FindWord(string input, string word)
        {
            string[] seperateWord = input.ToLower().Split(' ');
            if (seperateWord.Length == 0) return -1;
            for (int i = 0; i < seperateWord.Length; i++)
            {
                if (seperateWord[i] == word.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main1(string[] args)
        {
            Console.Write("Nhập câu: ");
            string inputSentence = Console.ReadLine();
            Console.Write("Nhập từ: ");
            string inputWord = Console.ReadLine();
            int k = FindWord(inputSentence, inputWord);
            if (k == -1)
            {
                Console.WriteLine($"Không tìm thấy từ {inputWord} trong câu của bạn ");
            }
            else
            {
                Console.WriteLine($"Từ {inputWord} đã được tìm thấy ở vị trí {k + 1}");
            }
        }
    }
}
