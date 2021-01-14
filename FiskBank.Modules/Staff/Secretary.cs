using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Secretary : AuthenticableStaff
    {
        /// <summary>
        /// Instance a new <see cref="Secretary"/>.
        /// </summary>
        /// <param name="name"><see cref="Secretary"/>'s full <paramref name="name"/>.</param>
        /// <param name="id"><see cref="Secretary"/>'s governmental <paramref name="id"/>.</param>
        /// <param name="password"><paramref name="password"/> to acess private area</param>
        public Secretary(string name, string id, string password) : base(name, id, password)
        {
            
        }

        public override double Salary()
        {
            return minimumSalary * 1.5;
        }
    }
}
