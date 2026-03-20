using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class AuditReport : Report
    {
        public override string GetContent()
        {
            return "Audit Report Content";
        }
    }
}
