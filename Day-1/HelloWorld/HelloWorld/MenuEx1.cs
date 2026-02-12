using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class MenuEx1
    {
        public void ShowInfo(int firstNo, int secondNo)
        {
            int choice, result;
            do
            {
                Console.WriteLine(" O P T I O N S ");
                Console.WriteLine(" ------------- ");
                Console.WriteLine("1. Addition ");
                Console.WriteLine("2. Subtraction ");
                Console.WriteLine("3. Multiplication  ");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Your Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        result = firstNo + secondNo;
                        Console.WriteLine("Sum  is  " + result);
                        break;
                    case 2:
                        result = firstNo - secondNo;
                        Console.WriteLine("Sub  is  " + result);
                        break;
                    case 3:
                        result = firstNo * secondNo;
                        Console.WriteLine("Mult  is  " + result);
                        break;
                    case 4:
                        return;
                }
            } while (choice != 4);
        }
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter 2 Number   ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            MenuEx1 menuEx1 = new MenuEx1();
            menuEx1.ShowInfo(a, b);
        }
    }
}
