using FiskBank.Modules.Staff;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Helpers
{
    internal class ReportHelper
    {
        public static void ToCreateTextReport(string name, DateTime dateTime, string report, List<string> reportList)
        {
            string reportText = $"{name} at {dateTime}: {report}";
            reportList.Add(reportText);
            Coordinator.schoolReport.Add(reportText);
        }
    }
}
