using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
    public class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
          
            Console.WriteLine("Details Of Current Account..");
        }
    }
}
