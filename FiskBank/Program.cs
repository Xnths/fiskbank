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
            ToCreateStudent();
            Console.ReadLine();
        }

        public static void ToCreateStudent()
        {
            Student student = new Kid("Lais", 0.0, "Paiol", "S/N", "Paiol Grande", "São Bento", "1249000");
            Student student1 = new Teen("João Vitor", 0.2, "Paiol", "S/N", "Paiol Grande", "São Bento", "12490000");
            Student student2 = new Adult("Jonathas Castilho", 0.0, "Paiol", "S/N", "Paiol Grande", "São Bento", "124900000");

            Console.WriteLine(student.Tuition());
            Console.WriteLine(student1.Tuition());
            Console.WriteLine(student2.Tuition());
        }
    }
}
