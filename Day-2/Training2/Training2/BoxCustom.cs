using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class BoxCustom
    {
        static void Main()
        {
            Employ e1 = new Employ();
            e1.empno = 1;
            e1.name = "Tushar";
            e1.basic = 83824;
            Employ e2 = new Employ();
            e2.empno = 2;
            e2.name = "Pranav";
            e2.basic = 90032;
            Employ e3 = new Employ();
            e3.empno = 3;
            e3.name = "Neerav";
            e3.basic = 90023;
            Student s1 = new Student();
            s1.sid = 1;
            s1.sname = "Aman";
            s1.city = "Bhopal";
            Student s2 = new Student();
            s2.sid = 2;
            s2.sname = "Irfan";
            s2.city = "Delhi";

            object[] arr = new object[] { e1, s1, e2, s2, e3 };
            foreach (object o in arr)
            {
                if (o is Employ)
                {
                    Employ employ = (Employ)o;
                    employ.ShowEmployDetails();
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }
}
