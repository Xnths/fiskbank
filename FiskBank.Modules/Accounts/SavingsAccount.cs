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
        public SavingsAccount(Student student, double balance) : base(student, balance)
        {

        }
        public double GetGain()
        {
            return gain + 0.12;
        }
    }
}
