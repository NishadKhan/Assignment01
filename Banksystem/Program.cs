using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank("Dhaka", 100);
            int select;
            b1.AddAccount(new Account("Ali", 5000, new Address("road no: 50", "House no:70", "city : Dhaka", "Country:Bangladesh")));
            b1.AddAccount(new Account("Bashar", 3000, new Address("road no: 51", "House no: 50", "city :Dhaka", "Country: Bangladesh")));
            b1.PrintAccountDetailes();

            Console.WriteLine("1.withdraw");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Transfer");
            select = Convert.ToInt32(Console.ReadLine());
            b1.Transaction(2);
           // b1.DeleteAccount(1);
            //Console.WriteLine();
            //Console.WriteLine();
            b1.PrintAccountDetailes();
            Console.ReadKey();
        }
    }
}
