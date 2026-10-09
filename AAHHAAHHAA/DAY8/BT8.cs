using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace AAHHAAHHAA.DAY8
{
    public class BT8
    {
        static void CreateBlankFile (string filepath)
        {
            try
            {
                File.Create (filepath).Close();
                Console.WriteLine("Create succesfully");
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DeleteFile (string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    File.Delete (filepath);
                    Console.WriteLine("Delete successfully");
                }
                else
                {
                    Console.WriteLine("This file does not exist");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CreateAndWrite(string filepath, string text)
        {
            try
            {
                File.WriteAllText(filepath, text);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CreateAndRead (string filepath, string text)
        {
            File.WriteAllText (filepath, text);
            StreamReader sr = new StreamReader(filepath);
            do
            {
                Console.WriteLine(sr.ReadLine());
            }
            while (sr.Peek() != -1);
            sr.Close();
        }
        static void CreateAddStringArray (string filepath, string[] s)
        {
            try
            {
                File.AppendAllLines(filepath,s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void CopyAndDisplay(string filepath, string destination)
        {
            try
            {
                File.Copy(filepath, destination);
                if (File.Exists(destination))
                {
                    StreamReader sr = new StreamReader(destination);
                    do
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    while (sr.Peek() != -1);
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void MoveFileInSameDirectory(string filepath, string destination)
        {
            try 
            {
                if (File.Exists(filepath))
                {
                    File.Move(filepath, destination);
                    Console.WriteLine("Move thanh cong");
                }
                else { Console.WriteLine("file khong ton tai"); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadFirstAndLastLine (string filepath)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    if (lines.Length > 0)
                    {
                        string firstline = lines[0];
                        string lastline = lines[lines.Length - 1];
                        Console.WriteLine($"Dong dau tien: {firstline}");
                        Console.WriteLine($"Dong cuoi cung: {lastline}");
                    }
                    else Console.WriteLine("file khong co gi");
                }
                else Console.WriteLine("file khong ton tai");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadNLastLine (string filepath, int n)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    int startIndex = lines.Length - n;
                    if (startIndex > 0)
                    {
                        for (int i = startIndex; i < lines.Length; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                    }
                    else Console.WriteLine("file empty");
                }
                else Console.WriteLine("file khong ton tai");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void ReadChosenLine (string filepath, int n)
        {
            try
            {
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    if (lines.Length > 0)
                    {
                        Console.WriteLine(lines[n-1]);
                    }
                    else Console.WriteLine("file empty");
                }
                else Console.WriteLine("file khong ton tai");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void StructureOfDirectory(string folderpath)
        {
            try
            {
                if (Directory.Exists(folderpath))
                {
                    DirectoryInfo dir = new DirectoryInfo(folderpath);
                    FileInfo[] allFile = dir.GetFiles("*", SearchOption.AllDirectories);
                    foreach (FileInfo file in  allFile)
                    {
                        Console.WriteLine("- " + file.FullName);
                    }
                    DirectoryInfo[] allDirs = dir.GetDirectories("*", SearchOption.AllDirectories);
                    foreach (DirectoryInfo subDir in allDirs)
                    {
                        Console.WriteLine("[Folder] " + subDir.FullName);
                    }
                }
                else
                {
                    Console.WriteLine("Thu muc khong ton tai!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main (string[] args)
        {
            string filepath = @"C:\Users\ASUS\UEH Assistant\mssv";
            string text = "That's enough,\nget out of here\n";
            string destination = @"C:\Users\ASUS\UEH Assistant\mssv\mytest_copy1";
            string destination2 = @"C:\Users\ASUS\UEH Assistant\mySAMEtest.txt";
            StructureOfDirectory(filepath);
        }
    }
}
