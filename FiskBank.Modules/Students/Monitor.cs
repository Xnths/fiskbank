using FiskBank.Modules.Helpers;
using FiskBank.Modules.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Students
{
    public class Monitor : Student, IEducator
    {
        public List<string> reports = new List<string>();
        /// <summary>
        /// Creates a new <see cref="Monitor"/><see cref="Student"/> with manual registry number. It is important to point out that monitors don't have a discount, for they receive the course as payment working at Fisk.
        /// </summary>
        /// <param name="name"><see cref="Monitor"/>'s full name.</param>
        /// <param name="streetName"><see cref="Monitor"/>'s house street.</param>
        /// <param name="number"><see cref="Monitor"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Monitor"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Monitor"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Monitor(string name, string password, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, password, 0.0, streetName, number, neighborhood, city, postalCode)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Monitor"/><see cref="Student"/> with manual registry number. It is important to point out that monitors don't have a discount, for they receive the course as payment working at Fisk.
        /// </summary>
        /// <param name="name"><see cref="Monitor"/>'s full name.</param>
        /// <param name="registry">Number to identify <see cref="Monitor"/>.</param>
        /// <param name="streetName"><see cref="Monitor"/>'s house street.</param>
        /// <param name="number"><see cref="Monitor"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Monitor"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Monitor"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Monitor(string name, string password, short registry, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, password, registry, 0.0, streetName, number, neighborhood, city, postalCode)
        {
        }

        /// <summary>
        /// Report Extra Acitivity given.
        /// </summary>
        /// <param name="report">Text describing what was done in the activity.</param>
        public void ToReportActivity(string name, DateTime acitivityTime, string report)
        {
            ReportHelper.ToCreateTextReport(name, acitivityTime, report, reports);
        }

        public override double Tuition()
        {
            return 0.0;
        }
    }
}
