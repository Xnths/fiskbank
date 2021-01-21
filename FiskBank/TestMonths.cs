using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank
{
    partial class Program
    {
        public static void OrderMonth()
        {
            var calendarMonths = new List<string>
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            var months = new List<string>()
            {
                "April",
                "March",
                "January",
                "February",
                "June",
                "May",
                "September",
                "December",
                "November",
                "July",
                "August",
                "October"
            };

            //var orderedMonths = months.OrderBy(month =>
            //{
            //    int i = calendarMonths.IndexOf(month);

            //    return month[i];
            //});

            //foreach (var item in orderedMonths)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
