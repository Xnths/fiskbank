using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Teacher : Educator
    {
        public Teacher(string name, string id) : base(name, id)
        {

        }
        
        public override double Salary()
        {
            return minimumSalary;
        }
    }
}
