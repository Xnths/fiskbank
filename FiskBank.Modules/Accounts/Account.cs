using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiskBank.Modules.Students;

namespace FiskBank.Modules.Accounts
{
    public abstract class Account : IComparable
    {
        public Student Student { get; }
        private double _balance;
        public static short InsufficientTranference { get; private set; }
        //The amount of Fisk Dollar the school has at the current time. It limits withdrawing greater values of its amount, for lacking of bills.
        private static double _fiskDollars = 0;
        public GenericList<string> log = new GenericList<string>();
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
            _fiskDollars += balance;

            log.AddItem(LogHelper.Log($"{student.Name}'s {nameof(Account)} created."));
        }

        public override bool Equals(object obj)
        {
            //Notice that the comparison is maden between Registries because this is the school's internal identification for students. There is no reason, thereby, to create another method of comparison, for students will always be represented as an Account and there is nothing that Registry represents outside the school.
            Account account = obj as Account;
            if (account == null) return false;
            return account.Student.Registry == this.Student.Registry;
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
            log.AddItem(LogHelper.Log($"Tranference of F$ {transference} to {account.Student.Name} account"));
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
                if (withdraw > _fiskDollars) throw new LackOfBillException(withdraw, _fiskDollars);
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
            _fiskDollars -= withdraw;
            log.AddItem(LogHelper.Log($"Withdraw of F${withdraw}."));
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
            log.AddItem(LogHelper.Log($"Deposit of F${deposit}."));
        }

        /// <summary>
        /// Return account's <see cref="Balance"/>.
        /// </summary>
        /// <returns></returns>
        public double ToCheckAccount()
        {
            log.AddItem($"{nameof(Account)} has been checked.");
            return Balance;
        }

        public int CompareTo(object obj)
        {
            var otherAccount = obj as Account;
            
            if(Student.Registry > otherAccount.Student.Registry)
            {
                return 1;
            }
            if(Student.Registry < otherAccount.Student.Registry)
            {
                return -1;
            }
            return 0;
        }
    }
}
