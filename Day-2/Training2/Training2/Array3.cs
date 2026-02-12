using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Array3
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
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("Max Value  " + max);
            Console.WriteLine("Min Value  " + min);
        }
        static void Main()
        {
            Array3 array3 = new Array3();
            array3.Show();
        }
    }
}
