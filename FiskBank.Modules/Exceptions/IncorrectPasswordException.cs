using System;
using System.Runtime.Serialization;

namespace FiskBank.Modules.Exceptions
{
    [Serializable]
    internal class IncorrectPasswordException : Exception
    {
        public IncorrectPasswordException() : base("Password is incorrect. Please, try again.")
        {
        }

        public IncorrectPasswordException(string message) : base(message)
        {
        }

        public IncorrectPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectPasswordException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}