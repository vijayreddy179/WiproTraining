using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class PdfFormatter : IReportFormatter
    {
        public string Format(string content)
        {
            return "PDF Format: " + content;
        }
    }
}
