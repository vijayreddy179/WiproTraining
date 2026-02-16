using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    abstract class Student
    {
        int sid;
        string name;
        double cgpa;

        public Student(int sid, string name, double cgpa)
        {
            this.sid = sid;
            this.name = name;
            this.cgpa = cgpa;
        }
        public override string ToString()
        {
            return $"Sid {sid} Name {name} CGPA {cgpa}";
        }
    }
    class vijay : Student
    {
        public vijay(int sid, string name, double cgpa) : base(sid,name,cgpa)
        {
        }
    }
    class vinay : Student
    {
        public vinay(int sid, string name, double cgpa) : base(sid,name,cgpa)
        {
        }
    }
    class Kabir : Student
    {
        public Kabir(int sid, string name, double cgpa) : base(sid,name,cgpa) 
        {
        }
    }
    internal class Abs
    {
       static void Main()
       {
            Student[] a = new Student[]
            {
                new vijay(1,"Vijay",9.5),
                new vinay(2,"vinay",9.3),
                new Kabir(3,"Kabir",9.2)
            };
            foreach(Student s in a)
            {
                Console.WriteLine(s);
            }
       }
    }
}
