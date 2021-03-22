using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Account a1 = new Account("Maftum", "8989", 200);
            Account a2 = new Account("Hasnain", "2323", 300);
            a1.Withdraw(50);
            a1.Deposit(200);
            a1.Transfer(300, a2);
            a1.showAllTransactions();
            a2.showAllTransactions();
        }
    }
}
