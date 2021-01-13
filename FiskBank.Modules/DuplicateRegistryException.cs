using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules
{
    public class DuplicateRegistryException : Exception
    {
        public DuplicateRegistryException()
        {

        }
        public DuplicateRegistryException(string message) : base(message)
        {

        }
    }
}
