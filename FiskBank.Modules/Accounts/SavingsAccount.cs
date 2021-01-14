using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiskBank.Modules.Students;

namespace FiskBank.Modules.Accounts
{
    public class SavingsAccount : Account
    {
        private static double gain = 1.12;
        /// <summary>
        /// Class to instance a new Savings Account.
        /// </summary>
        /// <param name="student">An instance of <see cref="Student"/> Class.</param>
        /// <param name="balance">Inicial amount to deposit at the start. It must be a positive number.</param>
        public SavingsAccount(Student student, double balance) : base(student, balance)
        {

        }
        /// <summary>
        /// Returns the amount of Savings income earn during the <paramref name="months"/> especified.
        /// </summary>
        /// <param name="months">Duration of time you want to calcule income based on current <see cref="Account.Balance"/>.</param>
        /// <returns></returns>
        public double GetGain(short months)
        {
            return Balance * Math.Pow(gain, months);
        }
    }
}
