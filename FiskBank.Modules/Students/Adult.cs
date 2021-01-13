using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Students
{
    public class Adult : Student
    {
        public Adult(string name, double discount, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, discount, streetName, number, neighborhood, city, postalCode)
        {
        }

        public Adult(string name, short registry, double discount, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, registry, discount, streetName, number, neighborhood, city, postalCode)
        {
        }

        public override double Tuition()
        {
            return discount * 180;
        }
    }
}
