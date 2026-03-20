using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class ReportFormatter
    {
        private IReportFormatter _formatter;

        public ReportFormatter(IReportFormatter formatter)
        {
            _formatter = formatter;
        }

        public string GetFormattedReport(string content)
        {
            return _formatter.Format(content);
        }
    }
}
