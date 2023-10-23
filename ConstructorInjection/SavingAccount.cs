using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    public class SavingAccount : IAccount
    {

        public SavingAccount() { }

        public void PrintDetails()
        {
          
            Console.WriteLine("Details Of Saving Account..");
        }
    }
}
