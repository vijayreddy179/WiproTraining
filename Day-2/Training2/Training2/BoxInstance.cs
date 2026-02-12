using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training2
{
    internal class BoxInstance
    {
        public void Show(object ob)
        {
            if (ob is Int32)
            {
                int x = (Int32)ob;
                Console.WriteLine("Integer Casting " + x);
            }
            if (ob is String)
            {
                string x = (String)ob;
                Console.WriteLine("String Casting " + x);
            }
            if (ob is Double)
            {
                double x = (Double)ob;
                Console.WriteLine("Double Casting  " + x);
            }
        }
        static void Main()
        {
            int x = 12;
            string str = "Hello";
            double y = 12.5;
            BoxInstance instance = new BoxInstance();
            instance.Show(x);
            instance.Show(str);
            instance.Show(y);
        }
    }
}
