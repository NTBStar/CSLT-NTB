using System;
using System.Collections.Generic;
using System.Text;

namespace AAHHAAHHAA.DAY7
{
    public class Matrix
    {
        static int[,] NhapKichThuoc()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] inputMatrix = new int[m, n];
            return inputMatrix;
        }
        static int[,] GanGiaTriRandom(int[,] matrix)
        {
            Random r = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = r.Next(1, 100);
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void PrintColumn(int[,] matrix, int c)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, c]);
            }
            Console.WriteLine();
        }
        static void PrintRow(int[,] matrix, int r)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                Console.Write(matrix[r, i] + "\t");
            }
            Console.WriteLine();
        }
        static int FindMax(int[,] matrix)
        {
            int max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
            return max;
        }
        static int MaxInRow(int[,] matrix, int x)
        {
            int max = matrix[x, 0];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[x, i] > max) max = matrix[x, i];
            }
            return max;
        }
        static int MinInRow(int[,] matrix, int x)
        {
            int min = matrix[x, 0];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[x, i] < min) min = matrix[x, i];
            }
            return min;
        }
        static int MaxInColumn(int[,] matrix, int x)
        {
            int max = matrix[0, x];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, x] > max) max = matrix[i, x];
            }
            return max;
        }
        static int MinInColumn(int[,] matrix, int x)
        {
            int min = matrix[0, x];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, x] > min) min = matrix[i, x];
            }
            return min;
        }
        static int[,] TransposeMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);
            int[,] Trans = new int[column, row];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Trans[j, i] = matrix[i, j];
                }
            }
            return Trans;
        }
        static string MainDiagonal(int[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j) { sb.Append($"{matrix[i, i], 5}");}
                    else
                    {
                        sb.Append($"{" ",5}");
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        static string SecondaryDiagonal(int[,] matrix)
        {
            StringBuilder sbb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (i+j == matrix.GetLength(0)-1) { sbb.Append($"{matrix[i, j],5}"); }
                    else
                    {
                        sbb.Append($"{" ",5}");
                    }
                }
                sbb.AppendLine();
            }
            return sbb.ToString();
        }
        static void Main2(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                int[,] matrix = NhapKichThuoc();
                GanGiaTriRandom(matrix);
                Console.WriteLine($"Ma trận của bạn:");
                PrintMatrix(matrix);
                //Console.WriteLine("Cột bạn chọn");
                //PrintColumn(matrix, 2);
                //Console.WriteLine("Hàng bạn chọn");
                //PrintRow(matrix, 3);
                //Console.WriteLine($"Phần tử lớn nhất là: {FindMax(matrix)}");
                //Console.WriteLine($"Phần tử lớn nhất dòng là: {MaxInRow(matrix,0)}");
                //Console.WriteLine(MaxInColumn(matrix,1));
                //Console.WriteLine(MinInRow(matrix,1));
                //Console.WriteLine(MinInColumn(matrix,2));
                int[,] Tmatrix = TransposeMatrix(matrix);
                Console.WriteLine("Ma trận chuyển vị: ");
                PrintMatrix(Tmatrix);
                Console.WriteLine("Đường chéo chính:");
            Console.WriteLine(MainDiagonal(matrix));
            Console.WriteLine(SecondaryDiagonal(matrix));
            }
        }
    }

