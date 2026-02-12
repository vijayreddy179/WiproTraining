using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class CaseEx1
    {
        public void Show(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hi I am Vijay Simha...");
                    break;
                case 2:
                    Console.WriteLine("Hi I am Kishore G...");
                    break;
                case 3:
                    Console.WriteLine("Hi I am Neerav Vivek...");
                    break;
                case 4:
                    Console.WriteLine("Hi I am Tushar Rajput...");
                    break;
                case 5:
                    Console.WriteLine("Hi I am Uday Pratap...");
                    break;
                default:
                    Console.WriteLine("Invalid Choice...");
                    break;
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("Enter Choice   ");
            choice = Convert.ToInt32(Console.ReadLine());
            CaseEx1 obj = new CaseEx1();
            obj.Show(choice);
        }
    }
}
