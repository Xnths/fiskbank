using FiskBank.Modules.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Students
{
    public class Monitor : Student, IEducator
    {
        public ArrayList reports = new ArrayList();
        public Monitor(string name, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, 0.0, streetName, number, neighborhood, city, postalCode)
        {
        }

        public Monitor(string name, short registry, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, registry, 0.0, streetName, number, neighborhood, city, postalCode)
        {
        }

        public void ToReportActivity(string report)
        {
            ReportHelper.ToCreateTextReport(Name, reports, report);
        }

        public override double Tuition()
        {
            return 0.0;
        }
    }
}
