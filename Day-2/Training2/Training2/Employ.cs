using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Employ
    {
        public int empno;
        public string name;
        public double basic;

        public void ShowEmployDetails()
        {
            Console.Write($"Employ No {empno} Employ Name  {name} Basic : {basic}");
        }
    }
}
