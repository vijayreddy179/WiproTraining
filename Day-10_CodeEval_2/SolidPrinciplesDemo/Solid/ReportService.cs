using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class ReportService
    {
        private IDataSource _dataSource;

        public ReportService(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Generate()
        {
            Console.WriteLine(_dataSource.GetData());
        }
    }
}
