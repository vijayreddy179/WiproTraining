using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Array2
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
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.WriteLine("Sum is  " + sum);
        }
        static void Main()
        {
            Array2 array = new Array2();
            array.Show();
        }
    }
}
