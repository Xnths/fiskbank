using FiskBank.Modules.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Comparer
{
    class CompareRegistry : IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            if(x == y)
            {
                return 0;
            }
            if(x.Student.Registry < y.Student.Registry)
            {
                return -1;
            }

            if(x.Student.Registry > y.Student.Registry)
            {
                return 1;
            }

            return x.CompareTo(y);
        }
    }
}
