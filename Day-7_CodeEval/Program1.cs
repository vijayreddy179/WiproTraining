using System;

// Step 1: Define delegate type
delegate int Operation(int a, int b);

class Program1
{
    // Step 2: Delegate methods
    static int Add(int a, int b) => a + b;

    static int Subtract(int a, int b) => a - b;

    static int Multiply(int a, int b) => a * b;

    static int Divide(int a, int b) => a / b;

    // Step 3: Callback mechanism
    static int PerformOperation(int a, int b, Operation op)
    {
        return op(a, b);
    }

    static void Main(string[] args)
    {
        // Step 4: Input handling
        Console.WriteLine("Enter first number:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter operation (add, subtract, multiply, divide):");
        string choice = Console.ReadLine();

        // Step 5: Output handling
        Operation op = null;

        switch (choice)
        {
            case "add":
                op = Add;
                break;
            case "subtract":
                op = Subtract;
                break;
            case "multiply":
                op = Multiply;
                break;
            case "divide":
                op = Divide;
                break;
            default:
                break;
        }

        if (op != null)
        {
            int res = PerformOperation(x, y, op);
            Console.WriteLine("Result: " + res);
        }
    }
}