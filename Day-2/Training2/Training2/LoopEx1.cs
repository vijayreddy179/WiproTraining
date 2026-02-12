using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class LoopEx1
    {
        public void Perfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("Perfect Number...");
            }
            else
            {
                Console.WriteLine("Not Perfect Number...");
            }
        }

        public void Prime(int n)
        {
            bool flag = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine("Prime Number...");
            }
            else
            {
                Console.WriteLine("Not-Prime Number...");
            }
        }
        public void EvenOdd(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Even Number...");
            }
            else
            {
                Console.WriteLine("Odd Number...");
            }
        }
        public void Menu(int n)
        {
            int choice;
            do
            {
                Console.WriteLine(" O P T I O N S ");
                Console.WriteLine(" ------------- ");
                Console.WriteLine("1. Even-Odd ");
                Console.WriteLine("2. Prime-Not");
                Console.WriteLine("3. Perfect-Not");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter Your Choice   ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EvenOdd(n);
                        break;
                    case 2:
                        Prime(n);
                        break;
                    case 3:
                        Perfect(n);
                        break;
                    case 4:
                        return;
                }
            } while (choice < n);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            LoopEx1 loopEx1 = new LoopEx1();
            loopEx1.Menu(n);
        }
    }
}
