using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Calculation
    {
        #region Mult
        public int Mult(int a, int b)
        {
            return a * b;
        }
        #endregion Mult

        #region Sub
        public int Sub(int a, int b)
        {
            return a - b;
        }
        #endregion Sub 

        #region Sum
        public int Sum(int a, int b)
        {
            return a + b;
        }
        #endregion Sum

        #region Main
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calc = new Calculation();
            Console.WriteLine("Sum   " + calc.Sum(a, b));
            Console.WriteLine("Sub   " + calc.Sub(a, b));
            Console.WriteLine("Mult  " + calc.Mult(a, b));
        }
        #endregion Main
    }
}
