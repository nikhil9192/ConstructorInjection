using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection
{
  public   interface IAccount {


        void PrintDetails();

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account a = new Account(ca);
            a.PrintAccounts();

            IAccount sa = new SavingAccount();
            Account a2 = new Account(sa);
            a2.PrintAccounts();

            Console.ReadLine();
        }
    }
}
