using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Md2
    {
        public void MatAdd()
        {
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];

            int n, m;
            Console.WriteLine("Enter No.of Rows and Coloumns for Matrix  ");
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Elements for Matrix-A");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter a[{0}][{1}] Elements ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter Elements for Matrix-B");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("Enter b[{0}][{1}] Elements ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("Matrix-A   ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix-B   ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition Is  ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(c[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            new Md2().MatAdd();
        }
    }
}
