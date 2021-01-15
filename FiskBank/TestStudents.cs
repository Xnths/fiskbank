using FiskBank.Modules.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank
{
    partial class Program
    {
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
    }
}
