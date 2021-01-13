using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class FinacialOperationException : Exception
    {
        public FinacialOperationException()
        {
        }
        public FinacialOperationException(string message) : base(message)
        {

        }

        public FinacialOperationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
