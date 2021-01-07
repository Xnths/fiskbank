using FiskBank;

namespace FiskBank.Accounts
{
    public class CheckingAccount : Account
    {
        
        public CheckingAccount(Student student) : base(student, 0.0)
        {
            
        }

        public override double GetGain()
        {
            return (base.GetGain() + 0.1);
        }
    }
}