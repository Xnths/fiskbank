using System;
using System.Collections.Generic;
using System.Text;
using FiskBank.Modules.Accounts;

namespace FiskBank.Modules
{
    public static class AccountExtention
    {
        public static void ShowName(this Account account)
        {
            Console.WriteLine(account.Student.Name);
        }
    }
}
