﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Students
{
    public class Kid : Student
    {
        /// <summary>
        /// Creates a new <see cref="Kid"/><see cref="Student"/> with automatic registry number.
        /// </summary>
        /// <param name="name"><see cref="Kid"/>'s full name.</param>
        /// <param name="discount">Discount a <see cref="Kid"/> can receive. If it is meant to be none, input 1.0.</param>
        /// <param name="streetName"><see cref="Kid"/>'s house street.</param>
        /// <param name="number"><see cref="Kid"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Kid"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Kid"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Kid(string name, string password, double discount, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, password, discount, streetName, number, neighborhood, city, postalCode)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Kid"/><see cref="Student"/> with manual registry number.
        /// </summary>
        /// <param name="name"><see cref="Kid"/>'s full name.</param>
        /// <param name="registry">Number to identify <see cref="Kid"/>.</param>
        /// <param name="discount">Discount a <see cref="Kid"/> can receive. If it is meant to be none, input 1.0.</param>
        /// <param name="streetName"><see cref="Kid"/>'s house street.</param>
        /// <param name="number"><see cref="Kid"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Kid"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Kid"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Kid(string name, string password, short registry, double discount, string streetName, string number, string neighborhood, string city, string postalCode) : base(name, password, registry, discount, streetName, number, neighborhood, city, postalCode)
        {
        }

        public override double Tuition()
        {
            return discount * 200.0;
        }
    }
}
