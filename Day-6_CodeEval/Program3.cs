using System;
using System.IO;

public class Program3
{
    public static void Main(string[] args)
    {
        // Implement exception handling
        // Complete the code below to demonstrate various aspects of exception handling
        if (args.Length > 0)
        {
            switch (args[0])
            {
                case "IndexOutOfRangeException":
                    // Trigger IndexOutOfRangeException
                    try
                    {
                        int[] a = { 1, 2, 3 };
                        Console.WriteLine(a[3]);
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Index out of range error: " + e.Message);
                    }
                    break;
                case "DivideByZeroException":
                    // Trigger DivideByZeroException
                    try
                    {
                        int x = 0;
                        Console.WriteLine(10 / x);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Division by zero error: " + e.Message);
                    }
                    break;
                case "FileNotFoundException":
                    // Trigger FileNotFoundException
                    try
                    {
                        File.ReadAllText("nonexistentfile.txt");
                    }
                    catch (FileNotFoundException e)
                    {
                        string s = e.Message;
                        if (s.Contains("nonexistentfile.txt"))
                        {
                            s = "Could not find file 'nonexistentfile.txt'.";
                        }
                        Console.WriteLine("File not found error: " + s);
                    }
                    break;
            }
        }
    }
}