using System;

class CustomCollection
{
    // Define internal data structure
    // Complete Step 1:............
    private string[] A = new string[10];

    // Implement indexer
    // Complete Step 2:............
    public string this[int index]
    {
        get
        {
            return GetValue(index);
        }
        set
        {
            SetValue(index, value);
        }
    }

    // Define method to set elements
    // Complete Step 3:............
    public void SetValue(int index, string value)
    {
        if (index < 0 || index >= A.Length)
        {
            throw new IndexOutOfRangeException("Index out of range");
            A[index] = value;
        }
    }

    // Define method to get elements
    // Complete Step 4:............
    public string GetValue(int index)
    {
        if (index < 0 || index >= A.Length)
        {
            throw new IndexOutOfRangeException("Index out of range");
            return A[index];
        }
    }
}

class Program2
{
    static void Main(string[] args)
    {
        // Create instance of CustomCollection
        // Complete Step 7:............
        CustomCollection collection = new CustomCollection();

        // Loop to set and get values based on user input
        for (int i = 0; i < 3; i++)
        {
            // Prompt the user to set elements
            Console.WriteLine("Enter index to set:");
            // Complete Step 5:............
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value to set:");
            // Complete Step 6:............
            string value = Console.ReadLine();

            // Prompt the user to get the elements
            Console.WriteLine("Enter index to get:");
            // Complete Step 8:............
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Retrieved value: " + collection[y]);
        }
    }
}