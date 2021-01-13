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
        public AuthenticableStaff(string name, string id, string password) : base(name, id)
        {
            _password = password;
        }
        
        public bool ToAuthenticate(string password)
        {
            return _authenticationHelper.ComparePassword(_password, password);
        }
    }
}
