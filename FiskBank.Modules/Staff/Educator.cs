using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public abstract class Educator : Staff
    {
        private static ArrayList reports = new ArrayList();

        public Educator(string name, string id) : base(name, id)
        {

        }

        public void ToReport(Staff staff, string text)
        {
            string report = staff.Name + ": " + text;
            reports.Add(report);
        }
    }
}
