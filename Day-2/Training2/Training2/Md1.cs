using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Md1
    {
        public void Show()
        {
            int[,] a = new int[10, 10];
            int n, m;
            Console.WriteLine("Enter No.of Rows and Columns   ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Elements into Array  ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter a[{0}][{1}] Elements ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements are  ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            new Md1().Show();
        }
    }
}
