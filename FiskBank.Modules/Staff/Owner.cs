using FiskBank.Modules.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public class Owner : IAuthenticable
    {
        private string _password;
        private AuthenticationHelper _authenticationHelper = new AuthenticationHelper();

        /// <summary>
        /// Instance a new <see cref="Owner"/>.
        /// </summary>
        /// <param name="password"><paramref name="password"/> to acess private area</param>
        public Owner(string password)
        {
            _password = password;
        }
        public bool ToAuthenticate(string password)
        {
            return _authenticationHelper.ComparePassword(_password, password);
        }
    }
}
