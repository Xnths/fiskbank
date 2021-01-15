using FiskBank.Modules;
using FiskBank.Modules.Accounts;
using FiskBank.Modules.Staff;
using FiskBank.Modules.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FiskBank
{
    public class Program
    {
        public static int operation;
        static void Main(string[] args)
        {
            URLArgumentExtractor url = new URLArgumentExtractor("fiskbank?fromCurrency=bit&toCurrency=fiskDollar&value=100");
            Console.WriteLine(url.GetArgument("fromCurrency"));
            Console.WriteLine(url.GetArgument("toCurrency"));
            Console.WriteLine(url.GetArgument("value"));
            Console.WriteLine(url.GetArgument("FROMcurrency"));
            Console.WriteLine(url.GetArgument("TOcurRENCY"));
            Console.WriteLine(url.GetArgument("value"));
            

            Console.ReadLine();
        }

        public static void ToCreateAccount()
        {
            Student student1 = new Teen("João Vitor", 0.2, "Paiol", "S/N", "Paiol Grande", "São Bento", "12490000");
            SavingsAccount savingsAccount = new SavingsAccount(student1, 1000);
            Console.WriteLine(savingsAccount.GetGain(12));
            savingsAccount.ToWithdraw(222);
            Console.WriteLine(savingsAccount.log.Count);
        }
    }
}
