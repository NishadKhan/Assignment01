using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    class Account
    {
        private int accountNumber=1;
        private static int myaccountnumber;
        private string accountName;
        private Double balance;
        private Address address;
        //private string v1;
        //private int v2;

        public Account( string accountName, double balance, Address address)
        {
            accountNumber = ++myaccountnumber;
            this.AccountName = accountName;
            this.Balance = balance;
            this.Address = address;
        }

    // /*   public Account(string v1, int v2, Address address)
    //    {
    //        this.v1 = v1;
    //        this.v2 = v2;
    //        this.address = address;
    //    }
    //*/
        //public int AccountNumber
        //{

        //    set { accountNumber = value; }
        //    get { return accountNumber; }
        //}
        public String AccountName
        {
            set { this.accountName = value; }
            get
            {
                return accountName;
            }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        
            public void Withdraw(double amount)
            {
                if (this.Balance - amount >= 200)
                {
                    this.Balance = this.Balance - amount;
                    Console.WriteLine("Withdraw successful");

                }
                else
                {
                    Console.WriteLine("No Balance");
                }
            }
        
            public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
            Console.WriteLine("Deposit Successful");
        }
       
        public void Transfer(double amount, Account receiver)
        {

            this.Withdraw(amount);
            receiver.Deposit(amount);
            Console.WriteLine("Transfer succcessful");
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", accountNumber, this.accountName, this.balance);
            Console.WriteLine(this.Address.GetAddress());
        }

        internal void Transfer(int amount, int receiver)
        {
            throw new NotImplementedException();
        }
    }
}
