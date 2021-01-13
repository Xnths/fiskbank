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
        public ArrayList reports = new ArrayList();
        public Teacher(string name, string id) : base(name, id)
        {
        }

        public override double Salary()
        {
            return minimumSalary;
        }

        public void ToReportActivity(string report)
        {
            ReportHelper.ToCreateTextReport(Name, reports, report);
        }
    }
}
