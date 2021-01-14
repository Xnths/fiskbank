using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class IT : AuthenticableStaff
    {
        /// <summary>
        /// Instance a new IT staff member.
        /// </summary>
        /// <param name="name"><see cref="IT"/> professional's full <paramref name="name"/>.</param>
        /// <param name="id"><see cref="IT"/> professional's governmental <paramref name="id"/>.</param>
        /// <param name="password"><paramref name="password"/> to acess private area</param>
        public IT(string name, string id, string password) : base(name, id, password)
        {

        }

        public override double Salary()
        {
            return minimumSalary * 1.4;
        }
    }
}
