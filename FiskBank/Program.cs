using FiskBank.Modules;
using FiskBank.Modules.Accounts;
using FiskBank.Modules.Staff;
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
            ToCreateStaff();
            Console.ReadLine();
        }

        public static void ToCreateAccount()
        {
            Student student = new Student("Jonathas Castilho", "Marte", "S/N", "Marcinha", "Marciano", "123");
            try
            {
                CheckingAccount checkingAccount = new CheckingAccount(student);
                SavingsAccount savingsAccount = new SavingsAccount(student, 1000.0);
                CheckingAccount checkingAccount2 = new CheckingAccount(student);
                SavingsAccount savingsAccount2 = new SavingsAccount(student, -1000.0);
            }
            catch(NegativeAmountException ex)
            {
                ToShowExceptionMessage(ex);
            }
            catch(NullReferenceException ex)
            {
                ToShowExceptionMessage(ex);
            }
        }

        public static void ToCreateDuplicateStudent()
        {
            try
            {
                Student student = new Student("Jonathas Castilho", "Marte", "S/N", "Marcinha", "Marciano", "123");
                Student student2 = new Student("Jonathas Castilho", 1, "Marte", "S/N", "Marcinha", "Marciano", "123");
            }
            catch (DuplicateRegistryException e)
            {
                ToShowExceptionMessage(e);
            }
        }
        public static void ToCreateStaff()
        {
            Coordinator coordinator = new Coordinator("Carina Ruiz", "1", "123");

            IT it = new IT("Jonathas Castilho", "2", "123");

            Secretary secretary = new Secretary("Paola", "3", "123");

            Teacher teacher = new Teacher("Jeff", "4");

            Owner owner = new Owner("123");

            Console.WriteLine(coordinator.Name);
            Console.WriteLine(it.Name);
            Console.WriteLine(secretary.Name);
            Console.WriteLine(teacher.Name);
            Console.WriteLine(owner.ToAuthenticate("123"));
        }
        public static void ToCreateStudents()
        {
            try
            {
                Student student1 = new Student("Jonathas Castilho", "Blá", "Bla", "Bla", "bla", "bla");
                Student student2 = new Student("Jonathas Castilho", "Blá", "Bla", "Bla", "bla", "bla");
                CheckingAccount account1 = new CheckingAccount(student1);
                CheckingAccount account2 = new CheckingAccount(student2);
                account1.ToDeposit(10);
                account1.ToTransfer(100, account2);

                Console.WriteLine(account1.Balance);
            }
            catch (Exception ex)
            {
                ToShowExceptionMessage(ex);
            }
            finally
            {
                operation++;
            }
        }

        public static void ToShowExceptionMessage(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
    }
}
