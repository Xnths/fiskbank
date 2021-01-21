using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiskBank.Modules.Students;
using FiskBank.Modules.Accounts;
using FiskBank.Modules.Extention;

namespace FiskBank
{
    partial class Program
    {
        public static void ToAddAccount()
        {
            var adult = new Adult(
                name: "Jonathas Castilho",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            var adult2 = new Adult(
                name: "Julia",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");
            var adult3 = new Adult(
                name: "Maria",
                discount: 1.0,
                streetName: "Paiol",
                number: "S/N",
                neighborhood: "Paiol Grande",
                city: "São Bento do Sapucaí",
                postalCode: "1234");

            var account = new CheckingAccount(adult);
            var account2 = new CheckingAccount(adult2);
            var account3 = new CheckingAccount(adult3);

            var list1 = new List<CheckingAccount>();
            list1.AddVariousItems(account3, account2, account, null, null);

            var listNotNull = list1.Where(item => item != null).OrderBy(item => item.Student.Name);

            var namesOrdered = listNotNull;

            foreach (var item in namesOrdered)
            {
                Console.WriteLine(item.Student.Name);
            }
        }
    }
}
