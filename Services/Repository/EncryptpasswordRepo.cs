using QuickBridge.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBridge.Services.Repository
{
    internal class EncryptpasswordRepo : IEncryptpassword
    {
        public string hashPassword(string password)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;

        }

        public bool verifyPassword(string password,string storedhash)
        {
            var isValid = BCrypt.Net.BCrypt.Verify(password, storedhash);
            return isValid;
        }
    }
}
