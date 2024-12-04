using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBridge.Services.Interface
{
    internal interface IEncryptpassword
    {
        public string hashPassword(string password);

        public bool verifyPassword(string password,string storedhash);
    }
}
