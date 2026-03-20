using System;

class Account
{
    // Define properties
    // Complete Step 1:............
    public string AccNo { get; set; }
    public string Name { get; set; }
    private decimal Bal;

    public Account(string accNo, string name)
    {
        AccNo = accNo;
        Name = name;
        Bal = 0;
    }

    // Define methods
    // Complete Step 2:............
    public void Deposit(decimal amt)
    {
        if (amt > 0)
        {
            Bal += amt;
            Console.WriteLine($"Deposited: ${amt:F2}");
            Console.WriteLine($"Account Balance: ${Bal:F2}");
        }
    }

    public void Withdrew(decimal amt)
    {
        if (amt > 0 && amt <= Bal)
        {
            Bal -= amt;
            Console.WriteLine($"Withdrew: ${amt:F2}");
            Console.WriteLine($"Account Balance: ${Bal:F2}");
        }
    }

    public decimal GetBal()
    {
        return Bal;
    }

}

class Program2
{
    static void Main(string[] args)
    {
        // Prompt the user to enter account details
        Console.WriteLine("Enter account number:");
        // Complete Step 3:............
        string accNo = Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        // Complete Step 4:............
        string name = Console.ReadLine();

        // Create an instance of the Account class
        // Complete Step 5:............
        Account acc = new Account(accNo, name);

        // Perform transactions
        // Complete Step 6:............
        acc.Deposit(100);
        acc.Withdrew(50);
    }
}
