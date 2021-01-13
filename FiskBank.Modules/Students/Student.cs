using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Students
{
    public abstract class Student
    {
        public string Name { get; }
        public short Registry { get; }
        public Address Address { get; private set; }
        internal double discount;
        public abstract double Tuition();
        private static short _registryNumber = 1;
        //Solution to non-complex database. This Array, then, stores the registry numbers, preventing duplicates.
        private static ArrayList _studentList = new ArrayList();

        public Student(string name, short registry, double discount, string streetName, string number, string neighborhood, string city, string postalCode)
        {
            //In case, registry number will be manually added
            ToTestDuplicateRegistry(registry, name);

            Name = name;
            Registry = registry;
            this.discount = 1.0 - discount;
            Address = new Address(streetName, number, neighborhood, city, postalCode);

            ToRegister(registry);
        }

        public Student(string name, double discount, string streetName, string number, string neighborhood, string city, string postalCode) :
            this(name, ToCreateRegistry(), discount, streetName, number, neighborhood, city, postalCode)
        {
            //In case the registry number is meant to be automatically generated
        }
        private void ToTestDuplicateRegistry(short registry, string name)
        {
            for (int i = 0; i < _studentList.Count; i++)
            {
                if (_studentList[i].ToString() == Convert.ToString(registry))
                    throw new DuplicateRegistryException("You tried to atribute " + name + " a registry number that already exists.");
            }
        }

        private static void ToRegister(short registry)
        {
            _studentList.Add(registry);
            _registryNumber++;
        }

        private static short ToCreateRegistry()
        {
            for (int i = 0; i < _studentList.Count; i++)
            {
                if (_studentList[i].ToString() == Convert.ToString(_registryNumber)) { _registryNumber++; break; }

            }
            return _registryNumber;
        }
    }
}
