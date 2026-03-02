using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class LambdaExample1
    {
        static void Main()
        {
            List<Employ> empList = new List<Employ>()
            {
                new Employ{Empno=1,Name="Vijay",Dept="DotNet",Desig="Manager",Basic=56765},
                new Employ{Empno=2,Name="Vinay",Dept="Java",Desig="Expert",Basic=34890},
                new Employ{Empno=3,Name="Bhanu",Dept="DotNet",Desig="Developer",Basic=67593},
                new Employ{Empno=4,Name="Akshith",Dept="DotNet",Desig="Manager",Basic=21987},
                new Employ{Empno=5,Name="Shiva",Dept="DotNet",Desig="Developer",Basic=76348},
            };
            var res1 = empList.Select(x => x);
            Console.WriteLine("Employ List: ");
            foreach (var v in res1)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Enter Employ No");
            int empno = Convert.ToInt32(Console.ReadLine());
            Employ employ = empList.Where(x => x.Empno == empno).FirstOrDefault();
            if (employ != null)
            {
                Console.WriteLine(employ);
            }
            else
            {
                Console.WriteLine("*** Record Not Found ***");
            }
            var projection = empList.Select(x => new { x.Empno, x.Name, x.Basic });
            Console.WriteLine("Projected Fields are ");
            foreach (var v in projection)
            {
                Console.WriteLine($"Employ No {v.Empno} Employ Name {v.Name} Basic {v.Basic}");
            }
            Console.WriteLine("Enter Department ");
            string dept = Console.ReadLine();
            var deptData = empList.Where(x => x.Dept == dept);
            foreach(var v in deptData)
            {
                Console.WriteLine(v);
            }
            var sortedData=empList.Select(x => x).OrderBy(x => x.Name).ToList();
            Console.WriteLine("Sort-By Name is ");
            foreach (var v in sortedData)
            {
                Console.WriteLine(v);
            }
            var sortByBasic=empList.Select(x=>x).OrderByDescending(x=>x.Basic).ToList();
            Console.WriteLine("Sort-By Basic Descending Order ");
            foreach(var v in  sortByBasic)
            {
                Console.WriteLine(v);
            }
        }
    }
}
