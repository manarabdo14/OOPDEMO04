using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgnment
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string _storedUsername = "Manar";
        private string _storedPassword = "password";
        private string _storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == _storedUsername && password == _storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == _storedUsername && role == _storedRole;
        }
    }
}
