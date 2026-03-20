using System;
using System.IO;

public class Program4
{
    public static void Main(string[] args)
    {
        // Implement advanced exception handling
        // Complete the code below to demonstrate various advanced aspects of exception handling
        if (args.Length > 0)
        {
            try
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
                            throw;
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
                            throw;
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
                            throw;
                        }
                        break;
                    case "CustomException":
                        // Trigger CustomException
                        throw new CustomException("This is a custom exception.");
                }
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom error: " + ex.Message);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex is FileNotFoundException && message.Contains("nonexistentfile.txt"))
                {
                    message = "Could not find file 'nonexistentfile.txt'.";
                }
                Console.WriteLine("An error occurred: " + message);
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
        }
    }
}

// Define a custom exception
public class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}