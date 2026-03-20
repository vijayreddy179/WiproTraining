using System;

class Vehicle
{
    // Define properties
    // Complete Step 1:............
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Define constructor
    // Complete Step 2:............
    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    // Define virtual method
    // Complete Step 3:............
    public virtual void GetInfo()
    {
    }
}

class Car : Vehicle
{
    // Override GetInfo method
    // Complete Step 4:............
    public Car(string make, string model, int year) : base(make, model, year)
    {
    }

    public override void GetInfo()
    {
        Console.WriteLine($"Car: {Year} {Make} {Model}");
    }
}

class Motorcycle : Vehicle
{
    // Override GetInfo method
    // Complete Step 5:............
    public Motorcycle(string make, string model, int year) : base(make, model, year)
    {

    }

    public override void GetInfo()
    {
        Console.WriteLine($"Motorcycle: {Year} {Make} {Model}");
    }

}

class Program1
{
    static void Main(string[] args)
    {
        // Prompt the user to enter vehicle details for Car
        Console.WriteLine("Enter car make:");
        // Complete Step 6:............
        string carMake = Console.ReadLine();

        Console.WriteLine("Enter car model:");
        // Complete Step 7:............
        string carModel = Console.ReadLine();

        Console.WriteLine("Enter car year:");
        // Complete Step 8:............
        int carYear = int.Parse(Console.ReadLine());

        // Prompt the user to enter vehicle details for Motorcycle
        Console.WriteLine("Enter motorcycle make:");
        // Complete Step 9:............
        string bikeMake = Console.ReadLine();

        Console.WriteLine("Enter motorcycle model:");
        // Complete Step 10:............
        string bikeModel = Console.ReadLine();

        Console.WriteLine("Enter motorcycle year:");
        // Complete Step 11:............
        int bikeYear = int.Parse(Console.ReadLine());

        // Create instances of Car and Motorcycle
        // Complete Step 12:............
        Vehicle c = new Car(carMake, carModel, carYear);
        Vehicle b = new Motorcycle(bikeMake, bikeModel, bikeYear);

        // Display vehicle information
        // Complete Step 13:............
        c.GetInfo();
        b.GetInfo();
    }
}