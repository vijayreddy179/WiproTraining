using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Array5
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
            Console.WriteLine("Enter the Element to Delete  ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x)
                {
                    for (int j = i; j < n; j++)
                    {
                        a[j] = a[j + 1];
                    }
                    n--;
                }
            }
            Console.WriteLine("List after Delete Operation  ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        static void Main()
        {
            new Array5().Show();
        }
    }
}
