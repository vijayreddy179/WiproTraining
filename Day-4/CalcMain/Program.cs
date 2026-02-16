using ClsCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClsCalculation;

namespace CalcMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter 2 Numbers  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation c = new Calculation();
            Console.WriteLine("Sum  " + c.Sum(a,b));
            Console.WriteLine("Sub  " + c.Sub(a,b));
            Console.WriteLine("Mult " + c.Mult(a,b));
        }
    }
}
