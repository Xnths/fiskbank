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
        /// <summary>
        /// <see cref="Student"/> Mountly tuition for classes.
        /// </summary>
        /// <returns></returns>
        public abstract double Tuition();
        private static short _registryNumber = 1;
        //Solution to non-complex database. This Array, then, stores the registry numbers, preventing duplicates.
        private static ArrayList _studentList = new ArrayList();

        /// <summary>
        /// Creates a new <see cref="Student"/> with manual registry number.
        /// </summary>
        /// <param name="name"><see cref="Student"/>'s full name.</param>
        /// <param name="registry">Number to identify <see cref="Student"/>.</param>
        /// <param name="discount">Discount a <see cref="Student"/> can receive. If it is meant to be none, input 1.0.</param>
        /// <param name="streetName"><see cref="Student"/>'s house street.</param>
        /// <param name="number"><see cref="Student"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Student"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Student"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
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

        /// <summary>
        /// Creates a new <see cref="Student"/> with automatic registry number.
        /// </summary>
        /// <param name="name"><see cref="Student"/>'s full name.</param>
        /// <param name="discount">Discount a <see cref="Student"/> can receive. If it is meant to be none, input 1.0.</param>
        /// <param name="streetName"><see cref="Student"/>'s house street.</param>
        /// <param name="number"><see cref="Student"/>'s house number.</param>
        /// <param name="neighborhood"><see cref="Student"/>'s house neighborhood name.</param>
        /// <param name="city"><see cref="Student"/>'s house city.</param>
        /// <param name="postalCode">City's postal Code.</param>
        public Student(string name, double discount, string streetName, string number, string neighborhood, string city, string postalCode) :
            this(name, ToCreateRegistry(), discount, streetName, number, neighborhood, city, postalCode)
        {
            //In case the registry number is meant to be automatically generated
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (obj == null) throw new DuplicateRegistryException(Name);
            return Registry == student.Registry;
        }
        private void ToTestDuplicateRegistry(short registry, string name)
        {
            for (int i = 0; i < _studentList.Count; i++)
            {
                if (_studentList[i].ToString() == Convert.ToString(registry))
                    throw new DuplicateRegistryException(Name);
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
