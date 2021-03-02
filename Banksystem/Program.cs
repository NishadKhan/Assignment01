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
           
            b1.AddAccount(new Account("Ali", 5000, new Address("road no: 50", "House no:70", "city : Dhaka", "Country:Bangladesh")));
            b1.AddAccount(new Account("Bashar", 3000, new Address("road no: 51", "House no: 50", "city :Dhaka", "Country: Bangladesh")));
            b1.PrintAccountDetailes();

            
            
        
            b1.Transaction(2);
            //b1.DeleteAccount(1);
            //b1.
            
            b1.PrintAccountDetailes();
            Console.ReadKey();
        }
    }
}
