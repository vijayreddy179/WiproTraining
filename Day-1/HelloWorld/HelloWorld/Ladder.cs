using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Ladder
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Hi I am Abhishek P");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Hi I am Aman L");
            }
            else if (choice == 3)
            {
                Console.WriteLine("Hi I am Harsh Patel");
            }
            else if (choice == 4)
            {
                Console.WriteLine("Hi I am Eshwar...");
            }
            else if (choice == 5)
            {
                Console.WriteLine("Hi I am Karthik...");
            }
            else
            {
                Console.WriteLine("Unknown Value...");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter Your Choice    ");
            choice = Convert.ToInt32(Console.ReadLine());
            Ladder ladder = new Ladder();
            ladder.Show(choice);
        }
    }
}
