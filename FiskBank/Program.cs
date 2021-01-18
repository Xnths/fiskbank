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
        static void Main(string[] args)
        {
            ToCreateDuplicateAccount();
            Console.ReadLine();
        }

        public static void ToCreateDuplicateAccount()
        {
            Adult adult = new Adult(
                name: "Jonathas Castilho",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            Adult adult2 = new Adult(
                name: "Julia",
                registry: 2,
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            Adult adult3 = new Adult(
                name: "Maria",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
        }

        public static void ToAddAccount()
        {
            Adult adult = new Adult(
                name: "Jonathas Castilho",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            Adult adult2 = new Adult(
                name: "Julia",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            Adult adult3 = new Adult(
                name: "Maria",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");

            CheckingAccount account = new CheckingAccount(adult);
            CheckingAccount account2 = new CheckingAccount(adult2);
            CheckingAccount account3 = new CheckingAccount(adult3);

            GenericList<CheckingAccount> list = new GenericList<CheckingAccount>();

            list.AddVariousItems(account, account2, account3);
            for(int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i].Student.Name);
            }
        }
    }
}
