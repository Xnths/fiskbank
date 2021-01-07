using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank
{
    public class Student
    {
        public string Name { get; private set; }
        public short Registry { get; private set; }
        public Address Address { get; private set; }

        public Student(string name, short registry, string streetName, string number, string neighborhood, string city, string postalCode)
        {
            Name = name;
            Registry = registry;
            Address = new Address(streetName, number, neighborhood, city, postalCode);
        }
        
    }
}
