using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class Address
    {
        public string StreetName { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string PostalCode { get; private set; }

        /// <summary>
        /// Instance a new Address.
        /// </summary>
        /// <param name="streetName">House street.</param>
        /// <param name="number">House number.</param>
        /// <param name="neighborhood">House neighborhood name.</param>
        /// <param name="city">House city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Address(string streetName, string number, string neighborhood, string city, string postalCode)
        {
            StreetName = streetName;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            PostalCode = postalCode;
        }
    }
}
