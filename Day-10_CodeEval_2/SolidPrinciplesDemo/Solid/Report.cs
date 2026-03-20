using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class Report
    {
        public virtual string GetContent()
        {
            return "Base Report";
        }
    }
}
