using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Monitor : Educator
    {
        public Monitor(string name, string id) : base(name, id)
        {
        }

        //Until the present moment monitors recieve the course as payment. Thereby, their salary is 0
        public override double Salary()
        {
            return minimumSalary * 0;
        }
    }
}
