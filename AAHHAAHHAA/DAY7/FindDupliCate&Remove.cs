using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY7
{
    public class FindDupliCate_Remove
    {
        static int Find(int[] arr, int x) //Tìm vị trí số được chọn
        {
            for (int i = 0; i < arr.Length; i++) 
            { 
                if (arr[i] == x) return i;
            }
            return -1;
        }
        static int[] MakingShortArray (int[] arr, int x) //Nhập arr, x chỉ số phần tử cần cắt bớt
        {
            int[] newarr = new int[arr.Length-x];
            for (int i = 0;i < arr.Length - x; i++)
            {
                newarr[i] = arr[i];
            }
            return newarr;
        }
        static int[] MoveToRight(int[] arr, int x)
        {
            int count = 0;
            for (int j = 0;  j < arr.Length; j++)
            {
                int y = Find(arr, x);
                if (y == -1) 
                {
                    int[] result1 = MakingShortArray(arr, count);
                    return result1;
                }
                else if (y == arr.Length-count-1)
                {
                    count++;
                    int[] result2 = MakingShortArray(arr, count);
                    return result2;
                    
                }
                else
                {
                    count++;
                    for (int i = y; i < arr.Length - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                }
            }
            int[] result3 = MakingShortArray(arr, count);
            return result3;
        }
        static void Main1(string[] args)
        {
            int[] arr = { 7, 8, 5, 6, 3, 5, 8 };
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine(string.Join(", ", MoveToRight(arr,20)));
        }
    }
}
