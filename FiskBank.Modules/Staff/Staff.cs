using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public abstract class Staff
    {
        public string Name { get; private set; }
        public string Id { get; private set; }
        protected static double minimumSalary = 1100.0;

        public Staff(string name, string id)
        {
            Name = name;
            Id = id;
        }

        /// <summary>
        /// Amount of <see cref="Staff"/>'s member <see cref="Salary"/>.
        /// </summary>
        /// <returns></returns>
        public abstract double Salary();
    }
}
