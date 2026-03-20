using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.DesignPattern
{
    class DocumentFactory
    {
        public static IDocument Create(string type)
        {
            if (type == "PDF") return new PdfDocument();
            if (type == "WORD") return new WordDocument();
            return null;
        }
    }
}
