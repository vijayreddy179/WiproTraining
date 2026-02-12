using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class CtoK
    {
        public double ConvertToK(double c)
        {
            double k = c+273.15;
            return k;
        }
        static void Main()
        {
            double c;
            Console.WriteLine("Enter Celsius Value   ");
            c = Convert.ToDouble(Console.ReadLine());
            CtoK ctoK = new CtoK();
            Console.WriteLine("Kelvin Value : " + ctoK.ConvertToK(c));
        }
    }
}
