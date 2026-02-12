using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class CaseEx2
    {
        public void Show(string dayName)
        {
            switch (dayName)
            {
                case "sun":
                    Console.WriteLine("Its Sunday....");
                    break;
                case "mon":
                    Console.WriteLine("Its Monday....");
                    break;
                case "tue":
                    Console.WriteLine("Its Tuesday....");
                    break;
                case "wed":
                    Console.WriteLine("Its Wednesday....");
                    break;
                case "thu":
                    Console.WriteLine("Its Thursday....");
                    break;
                case "fri":
                    Console.WriteLine("Its Friday....");
                    break;
                case "sat":
                    Console.WriteLine("Its Saturday....");
                    break;
            }
        }
        static void Main()
        {
            string dayName;
            Console.WriteLine("Enter 3 chars of Day Name   ");
            dayName = Console.ReadLine();
            CaseEx2 caseEx2 = new CaseEx2();
            caseEx2.Show(dayName);
        }
    }
}
