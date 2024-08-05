using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string[] godWords = File.ReadAllLines("D:\\Godspeak\\HAPPY.txt");
        Console.Write("God says... ");
        Random random = new Random();
        for (int i = 0; i < 30; i++)
        {
            int rNum = random.Next(godWords.Length);
            Console.Write(godWords[rNum] + " ");
        }

    }
}
