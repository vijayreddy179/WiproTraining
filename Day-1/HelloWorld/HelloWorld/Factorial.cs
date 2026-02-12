using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Factorial
    {
        public void Calc(int n)
        {
            int f = 1;
            int i = 1;
            while (i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine("Factorial Value  " + f);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter N value   ");
            n = Convert.ToInt32(Console.ReadLine());
            Factorial factorial = new Factorial();
            factorial.Calc(n);
        }
    }
}
