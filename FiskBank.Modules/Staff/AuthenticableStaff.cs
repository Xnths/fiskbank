using FiskBank.Modules.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskBank.Modules.Staff
{
    public abstract class AuthenticableStaff : Staff, IAuthenticable
    {
        private string _password;
        private AuthenticationHelper _authenticationHelper = new AuthenticationHelper();
        /// <summary>
        /// Instance a member in <see cref="Staff"/>, which has authentication.
        /// </summary>
        /// <param name="name"><see cref="Staff"/>'s member full <paramref name="name"/>.</param>
        /// <param name="id"><see cref="Staff"/>'s member governmental <paramref name="id"/>.</param>
        /// <param name="password"><paramref name="password"/> to acess private area.</param>
        public AuthenticableStaff(string name, string id, string password) : base(name, id)
        {
            _password = password;
        }
        /// <summary>
        /// Compare password's attempts with correct password.
        /// </summary>
        /// <param name="password">Caracters to try acessing private area.</param>
        /// <returns></returns>
        public bool ToAuthenticate(string password)
        {
            return _authenticationHelper.ComparePassword(_password, password);
        }
    }
}
