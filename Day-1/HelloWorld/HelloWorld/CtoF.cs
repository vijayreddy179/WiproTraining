using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class CtoF
    {
        public double ConvertToF(double c)
        {
            double f = ((9 * c) / 5) + 32;
            return f;
        }
        static void Main()
        {
            double c;
            Console.WriteLine("Enter Celsius Value   ");
            c = Convert.ToDouble(Console.ReadLine());
            CtoF ctoF = new CtoF();
            Console.WriteLine("Fahrenheit Value  " + ctoF.ConvertToF(c));
        }
    }
}
