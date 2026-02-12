using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Array6
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
            Console.WriteLine("Enter the Element to Insert  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Position to Insert  ");
            int p = Convert.ToInt32(Console.ReadLine());
            n++;
            for (int i = n; i >= p; i--)
            {
                a[i] = a[i - 1];
            }
            a[p - 1] = x;
            Console.WriteLine("List after Insertion  ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Main()
        {
            new Array6().Show();
        }
    }
}
