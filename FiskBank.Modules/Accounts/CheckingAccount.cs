using FiskBank.Modules.Students;

namespace FiskBank.Modules.Accounts
{
    public class CheckingAccount : Account, IAccount
    {
        
        public CheckingAccount(Student student) : base(student, 0.0)
        {
            
        }

        public double GetGain()
        {
            return gain + 0.1;
        }
    }
}