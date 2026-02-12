using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Voting
    {
        public void Check(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("You are Elligible for Voting...");
            }
            else
            {
                Console.WriteLine("You Cannot Vote...");
            }
        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter Age   ");
            age = Convert.ToInt32(Console.ReadLine());
            Voting voting = new Voting();
            voting.Check(age);
        }
    }
}
