using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiskBank.Modules.Students;

namespace FiskBank.Modules.Accounts
{
    public class SavingsAccount : Account, IAccount
    {
        /// <summary>
        /// Class to instance a new Savings Account.
        /// </summary>
        /// <param name="student">An instance of <see cref="Student"/> Class.</param>
        /// <param name="balance">Inicial amount to deposit at the start. It must be a positive number.</param>
        public SavingsAccount(Student student, double balance) : base(student, balance)
        {

        }
        public double GetGain()
        {
            return gain + 0.12;
        }
    }
}
