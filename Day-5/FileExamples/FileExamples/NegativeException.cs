using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExamples
{
    internal class NegativeException : ApplicationException
    {
        public NegativeException(string error) : base(error) { }
    }
}
