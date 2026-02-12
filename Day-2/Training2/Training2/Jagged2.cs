using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class Jagged2
    {
        static void Main()
        {
            string[] mt1 = new string[] { "MileStone-1", "Mcq-1", "Labs:1-10" };
            string[] mt2 = new string[] { "MileStone-2", "Labs:11-15" };
            string[] mt3 = new string[] { "Project-1", "Virtual Labs", "Mcq-2" };
            string[] mt4 = new string[] { "Capstone Project", "Final MCQ" };
            string[][] dynamics = new string[4][];

            dynamics[0] = mt1;
            dynamics[1] = mt2;
            dynamics[2] = mt3;
            dynamics[3] = mt4;

            Console.WriteLine("To Finish the Course these the Modules to Clear...");
            for (int i = 0; i < dynamics.Length; i++)
            {
                foreach (string s in dynamics[i])
                {
                    Console.Write(s + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
