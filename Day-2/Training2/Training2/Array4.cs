using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Array4
    {
        public void Show()
        {
            int[] a = new int[10];
            int n;
            Console.WriteLine("Enter Size of Array  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} Elements into Array  ", n);
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int x;
            Console.WriteLine("Enter the Element to Search  ");
            x = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("Element Found at " + i + " Position");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Element Not Found...!");
            }
        }
        static void Main()
        {
            new Array4().Show();
        }
    }
}
