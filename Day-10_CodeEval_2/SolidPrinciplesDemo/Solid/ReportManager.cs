using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class ReportManager
    {
        public string GenerateReport()
        {
            return "Report Content";
        }

        public void SaveToFile(string report)
        {
            Console.WriteLine("Saving report...");
        }
    }
}
