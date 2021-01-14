using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiskBank.Modules.Students;

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

        /// <summary>
        /// Receive <see cref="Student"/> information to create a new <see cref="Account"/>.
        /// </summary>
        /// <exception cref="NegativeAmountException">In case <see cref="Balance"/> has been set as negative number.</exception>
        /// <exception cref="NullReferenceException">If <see cref="Student"/> argument is null.</exception>
        /// <param name="student">An instance of <see cref="Student"/> Class.</param>
        /// <param name="balance">Inicial Account's <see cref="Balance"/>.</param>
        public Account(Student student, double balance)
        {
            if (balance < 0) throw new NegativeAmountException("set initial value as");
            Student = student ?? throw new NullReferenceException("The student referenced does not exist.");
            Balance = balance;
            fiskDollars += balance;
        }

        /// <summary>
        /// Account's <see cref="Balance"/>.
        /// </summary>
        /// <exception cref="NegativeAmountException">If it has been tried to set balance as negative number</exception>
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
        /// <summary>
        /// Tranfer an amount to another.<see cref="Account"/>
        /// </summary>
        /// <exception cref="NegativeAmountException">If amount transfered was especified as negative.</exception>
        /// <exception cref="InsufficientBalanceException">If amount meant to be transfered is greater than account's<see cref="Balance"/>.</exception>
        /// <param name="transference">Amount of money to be transfered.</param>
        /// <param name="account">Account meant transfer the amount especificated.</param>
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
        /// <summary>
        /// Withdraws money.
        /// </summary>
        /// <exception cref="NegativeAmountException">If amount especificated is negative.</exception>
        /// <exception cref="InsufficientBalanceException">If amount meant to be withdrawn is greater than account's</exception>
        /// <exception cref="LackOfBillException">If there is not enough money at Fisk.</exception>
        /// <param name="withdraw">The amount it is meant to be withdrawn.</param>
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
        /// <summary>
        /// Deposit money to the account.
        /// </summary>
        /// <exception cref="NegativeAmountException">If amount especificated is negative.</exception>
        /// <param name="deposit">Amount of money to be deposited</param>
        public void ToDeposit(double deposit)
        {
            if (deposit < 0) throw new NegativeAmountException(nameof(deposit));
            Balance += deposit;
        }
    }
}
