using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Params
    {
        public void Attendance(int dayNo, params string[] students)
        {
            Console.Write("Day  " + dayNo + "   ");
            foreach (string student in students)
            {
                Console.Write(student + "    ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Params p = new Params();
            p.Attendance(1, "Ganesh", "Kabir", "Yash");
            p.Attendance(2, "Ganesh", "Yash", "Harsh", "Kishore");
            p.Attendance(3, "Tushar", "Uday", "Yash", "Eshwar", "Rithwik", "Vinay");
        }
    }
}
