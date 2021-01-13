using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class NegativeAmountException : Exception
    {
        public string ParamName { get; }
        public NegativeAmountException()
        {

        }
        public NegativeAmountException(string paramName) : base("You tried to " + paramName + " a negative amount.")
        {
            ParamName = paramName;
        }
        public NegativeAmountException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
