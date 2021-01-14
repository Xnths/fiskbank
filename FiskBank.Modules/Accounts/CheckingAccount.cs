using FiskBank.Modules.Students;
using System;

namespace FiskBank.Modules.Accounts
{
    public class CheckingAccount : Account
    {
        /// <summary>
        /// Class to instance a new Checking Account
        /// </summary>
        /// <param name="student">An instance of <see cref="Student"/> Class.</param>
        public CheckingAccount(Student student) : base(student, 0.0)
        {
            
        }
    }
}