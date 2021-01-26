using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    internal interface IEducator
    {
        void ToReportActivity(string name, DateTime activityTime, string report);
    }
}
