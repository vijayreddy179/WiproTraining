using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Student
    {
        public int sid;
        public string sname;
        public string city;

        public void ShowStudentInfo()
        {
            Console.Write($"Student No {sid} Student Name  {sname} City : {city}");
        }
    }
}
