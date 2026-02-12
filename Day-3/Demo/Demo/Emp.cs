using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Emp
    {
        int empid;
        string name;
        double salary;

        public Emp()
        {
            empid = 1;
            name = "Vijay";
            salary = 48369;
        }

        public Emp(int empid, string name, double salary)
        {
            this.empid = empid;
            this.name = name;
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"Employ Id = {empid} Employ Name = {name} Employ Salary = {salary}";
        }
    }
}
