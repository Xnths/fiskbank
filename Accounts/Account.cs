using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Accounts
{
    public abstract class Account
    {
        public Student Student { get; private set; }
        private double _balance;

        //The amount of Fisk Dollar at the school limits withdrawing greater values of its amount.
        protected static double fiskDollars = 0;

        public double Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0) return;
                _balance = value;
            }
        }

        public Account(Student student, double amount)
        {
            Student = student;
            Balance = amount;
        }

        public string ToTransfer(double amount, Account account)
        {
            ToWithdraw(amount);
            account.ToDeposit(amount);
            return "Transference successfuly done!";
        }

        public string ToWithdraw(double amount)
        {
            if (fiskDollars < amount) return "We do not have Fisk Dollars to give you. Wait until someone make a deposit.";
            if (amount > Balance) return "The amount you want to withdraw is greater than your balance!";
            
            //If there is enough Fisk Dollars at the school and the student also has balance to withdraw, this part will complete the extraction of money
            fiskDollars -= amount;
            Balance -= amount;
            return "Withdrawing sucessfuly done! Your balance is R$" + Balance + " now";
        }

        public void ToDeposit(double amount)
        {
            Balance += amount;
        }

        //Amount of money they earn each month, if they don't withdraw it.
        //By default its value is 1, for it means the person won't gain any amount of money per mounth
        public virtual double GetGain()
        {
            return 1.0;
        }
    }
}
