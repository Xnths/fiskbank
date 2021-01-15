using FiskBank.Modules.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class InsufficientBalanceException : FinacialOperationException
    {
        private double _amount;
        private double _balance;
        public InsufficientBalanceException()
        {

        }
        public InsufficientBalanceException(double amount, double balance) : this($"You tried to withdraw F${amount} in an {nameof(Account)}'s balance of F${balance}")
        {
            _amount = amount;
            _balance = balance;
        }
        public InsufficientBalanceException(string message) : base(message)
        {
        }
        public InsufficientBalanceException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
