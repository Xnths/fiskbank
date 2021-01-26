using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Coordinator : AuthenticableStaff
    {
        internal static List<string> schoolReport = new List<string>();
        /// <summary>
        /// Instance a new <see cref="Coordinator"/>.
        /// </summary>
        /// <param name="name"><see cref="Coordinator"/>'s full <paramref name="name"/></param>
        /// <param name="id"><see cref="Coordinator"/>'s governmental <paramref name="id"/></param>
        /// <param name="password"><paramref name="password"/> to acess private area</param>
        public Coordinator(string name, string id, string password) : base(name, id, password)
        {

        }

        public List<string> ToSeeReports()
        {
            //Athentication method
            return schoolReport;
        }

        public override double Salary()
        {
            return minimumSalary * 2;
        }
    }
}
