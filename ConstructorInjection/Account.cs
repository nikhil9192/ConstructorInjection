using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    internal class Account
    {
        private IAccount account;

        public Account(IAccount account) 
        {
            this.account = account;
        }

        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }
}
