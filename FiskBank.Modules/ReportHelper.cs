﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules
{
    internal class ReportHelper
    {
        public static void ToCreateTextReport(string name, ArrayList reportList, string report)
        {
            string reportText = name + ": " + report;
            reportList.Add(reportText);
        }
    }
}