using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsReflectionExample3
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student()
        {
            RollNo = 0;
            Name = "Hello World";
        }

        public Student(int RollNo, string Name)
        {
            this.RollNo = RollNo;
            this.Name = Name;
        }

        public void ShowCompany()
        {
            Console.WriteLine("Its from Capgemini...");
        }

        public override string ToString()
        {
            return "Roll No  " + RollNo + " Name " + Name;
        }

        public void ShowInfo(string name)
        {
            Console.WriteLine("Student Name " + name);
        }

        public void Greeting(string name)
        {
            Console.WriteLine("Good Morning  " + name);
        }
    }
}
