using FiskBank.Modules.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Teacher : Staff, IEducator
    {
        public List<string> reports = new List<string>();
        /// <summary>
        /// Instance a new <see cref="Teacher"/>.
        /// </summary>
        /// <param name="name"><see cref="Teacher"/>'s <paramref name="name"/>.</param>
        /// <param name="id"><see cref="Teacher"/>'s governmental <paramref name="id"/>.</param>
        public Teacher(string name, string id) : base(name, id)
        {
        }

        public override double Salary()
        {
            return minimumSalary;
        }

        /// <summary>
        /// Report class given.
        /// </summary>
        /// <param name="report">Text describing the activity given</param>
        public void ToReportActivity(string report)
        {
            ReportHelper.ToCreateTextReport(Name, reports, report);
        }
    }
}
