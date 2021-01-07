using FiskBank.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FiskBank v0.1!");

            Console.WriteLine("Please, you need to registry before continue using the program. Then, What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What's your regristry?");
            string registryString = Console.ReadLine();
            short registry = Convert.ToInt16(registryString);
            Console.WriteLine();

            Console.WriteLine("Okay. Now, please type the name of your house's Street:");
            string streetName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("What's its number?");
            string number = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Which neighborhood do you live?");
            string neighborhood = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Which city do you belong?");
            string city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Which is its postal code?");
            string postalCode = Console.ReadLine();
            Console.WriteLine();

            Student student = new Student(name, registry, streetName, number, neighborhood, city, postalCode);

            Console.WriteLine("Creating your account... Done!");
            CheckingAccount checkingAccount = new CheckingAccount(student);

            bool apply = false;

            Console.WriteLine("How much money do you want to deposit?");
            string amountString = Console.ReadLine();
            double amount = Convert.ToDouble(amountString);
            Console.WriteLine();

            while (!apply)
            {
                Console.WriteLine("F$" + amount + ", is that it? Type Enter to confirm or another value to change it.");
                string confirm = Console.ReadLine();
                Console.WriteLine();

                if (confirm == "")
                {
                    checkingAccount.ToDeposit(amount);
                    apply = true;
                }
                else
                {
                    amount = Convert.ToDouble(confirm);
                }
            }

            //Implement while with boolean to confirm the deposit


            Console.WriteLine(checkingAccount.Student.Name + ", your balance is F$" + checkingAccount.Balance);
            Console.WriteLine();

            Student patricia = new Student("Patricia", 122, "Centro", "12", "Centro", "SBS", "69");
            CheckingAccount patriciaAccount = new CheckingAccount(patricia);
            patriciaAccount.ToDeposit(120000);

            Console.WriteLine("Transfer to Patricia's account some money, please. Safe procedures... :D");
            string tranAmountString = Console.ReadLine();
            double tranAmount = Convert.ToDouble(tranAmountString);
            checkingAccount.ToTransfer(tranAmount, patriciaAccount);
            Console.WriteLine();

            Console.WriteLine("'Thank you', she said. Your balance is F$" + checkingAccount.Balance + ". Meanwhile, Patricia's is F$" + patriciaAccount.Balance);
            Console.WriteLine("Stading by. Press Enter to close the program...");
            Console.ReadLine();
        }
    }
}
