using FiskBank.Modules;
using FiskBank.Modules.Accounts;
using FiskBank.Modules.Staff;
using FiskBank.Modules.Students;
using FiskBank.Modules.Extention;
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
            ToAddAccount();
            Console.ReadLine();
        }

        public static void OrderMonth()
        {
            var calendarMonths = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var months = new List<string>()
            {
                "April",
                "March",
                "January",
                "February",
                "June",
                "May",
                "September",
                "December",
                "November",
                "July",
                "August",
                "October"
            };

            //var orderedMonths = months.OrderBy(month =>
            //{
            //    int i = calendarMonths.IndexOf(month);

            //    return month[i];
            //});

            //foreach (var item in orderedMonths)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static void ToUseList()
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
                registry: 2,
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
            ToShowParams(adult, adult2, adult3);
        }

        public static void ToShowParams(params Adult[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }

        public static void ToCreateDuplicateAccount()
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
                registry: 2,
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
        }

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
