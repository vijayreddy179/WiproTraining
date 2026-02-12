using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Company
    {
        static double salary;
        public void PaySalary(double sal)
        {
            salary += sal;
        }
        static void Main(string[] args)
        {
            Company a=new Company();
            Company b=new Company();
            Company c=new Company();
            Company d=new Company();

            a.PaySalary(77422);
            b.PaySalary(66623);
            c.PaySalary(67711);
            d.PaySalary(66233);
            Console.WriteLine($"Total Salary = {salary}");
        }
    }
}
