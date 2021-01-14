﻿using FiskBank.Modules.Students;

namespace FiskBank.Modules.Accounts
{
    public class CheckingAccount : Account, IAccount
    {
        /// <summary>
        /// Class to instance a new Checking Account
        /// </summary>
        /// <param name="student">An instance of <see cref="Student"/> Class.</param>
        public CheckingAccount(Student student) : base(student, 0.0)
        {
            
        }

        public double GetGain()
        {
            return gain + 0.1;
        }
    }
}