using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSExample
{
    internal class Nullable1
    {
        static void Main()
        {
            Emp emp1 = new Emp();
            emp1.Empno = 1;
            emp1.Name = "Vijay";


            Emp emp2 = new Emp();
            emp2.Empno = 2;
            emp2.Name = "Simha";
            emp2.LeaveDays = 3;

            if (emp1.LeaveDays.HasValue)
            {
                Console.WriteLine($"{emp1.Name} taken leave Already...");
            }
            else
            {
                Console.WriteLine($"{emp1.Name} No Leave Taken. You Can take leave now...");
            }

            if (emp2.LeaveDays.HasValue)
            {
                Console.WriteLine($"{emp2.Name} taken leave Already...");
            }
            else
            {
                Console.WriteLine($"{emp2.Name} No Leave Taken. You Can take leave now...");
            }
        }
    }
}
