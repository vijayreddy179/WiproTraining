using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Md4
    {
        static void Main()
        {
            int[,] arr = new int[2, 3];

            // Taking Input from User
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter arr[{i}][{j}]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Elements of Array:");

            // Iterating and Printing the elements of 2D array
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
