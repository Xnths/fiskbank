using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class LackOfBillException : Exception
    {
        public double FiskDollars { get; }
        public double Amount { get; }
        public LackOfBillException()
        {

        }
        public LackOfBillException(string message) : base(message)
        {

        }
        public LackOfBillException(double amount, double fiskDollars) : this($"We only have F$ {fiskDollars} but you requested F${ amount}. We ask you sorry for the inconvinience.")
        {
            Amount = amount;
            FiskDollars = fiskDollars;
        }
        public LackOfBillException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
