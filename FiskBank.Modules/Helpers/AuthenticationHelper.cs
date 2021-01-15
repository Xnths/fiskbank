using System;
using System.Collections.Generic;
using System.Text;

namespace FiskBank.Modules.Helpers
{
    internal class AuthenticationHelper
    {
        public bool ComparePassword(string correctPassword, string attemptPassword)
        {
            return correctPassword == attemptPassword;
        }
    }
}
