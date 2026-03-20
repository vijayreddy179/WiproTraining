using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemo.Solid
{
    class DatabaseSource : IDataSource
    {
        public string GetData()
        {
            return "Data from database";
        }
    }
}
