using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class ArrayEx2
    {
        public void Show()
        {
            string[] names = new string[]
            {
                "Tushar","Pranav","Aman","Abhishek","Aryan","Harsh","Eshwar","Neerav"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void Main()
        {
            ArrayEx2 arrayEx2 = new ArrayEx2();
            arrayEx2.Show();
        }
    }
}
