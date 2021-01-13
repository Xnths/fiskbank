using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Accounts
{
    public abstract class Account
    {
        public Student Student { get; }
        private double _balance;
        protected static double gain = 1.0;
        public static short InsufficientTranference { get; private set; }
        //The amount of Fisk Dollar at the school limits withdrawing greater values of its amount.
        protected static double fiskDollars = 0;

        public Account(Student student, double balance)
        {
            if (balance < 0) throw new NegativeAmountException("set initial value as");
            Student = student ?? throw new NullReferenceException("The student referenced does not exist.");
            Balance = balance;
            fiskDollars += balance;
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0) throw new NegativeAmountException(nameof(value));
                _balance = value;
            }
        }
        public void ToTransfer(double transference, Account account)
        {
            try
            {
                if (transference < 0) throw new NegativeAmountException(nameof(transference));
                if (transference > Balance) throw new InsufficientBalanceException(transference, Balance);
            }
            catch (InsufficientBalanceException ex)
            {
                InsufficientTranference++;
                throw new InsufficientBalanceException("There was an error with the Tranference", ex);
            }
            Balance -= transference;
            account.ToDeposit(transference);
        }
        public void ToWithdraw(double withdraw)
        {
            try
            {
                if (withdraw < 0) throw new NegativeAmountException(nameof(withdraw));
                if (withdraw > Balance) throw new InsufficientBalanceException(withdraw, Balance);
                if (withdraw > fiskDollars) throw new LackOfBillException(withdraw, fiskDollars);
            }
            catch(LackOfBillException ex)
            {
                throw new LackOfBillException("There was an error with the Withdraw.", ex);
            }
            catch(InsufficientBalanceException ex)
            {
                throw new InsufficientBalanceException("There was an error with the Withdraw.", ex);
            }
            Balance -= withdraw;
            fiskDollars -= withdraw;
        }

        public void ToDeposit(double deposit)
        {
            if (deposit < 0) throw new NegativeAmountException(nameof(deposit));
            Balance += deposit;
        }
    }
}
