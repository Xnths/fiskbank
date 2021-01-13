using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Secretary : AuthenticableStaff
    {
        public Secretary(string name, string id, string password) : base(name, id, password)
        {
            
        }

        public override double Salary()
        {
            return minimumSalary * 1.5;
        }
    }
}
