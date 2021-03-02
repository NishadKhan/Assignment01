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


        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            accountNumber= accountNumber+ myaccountnumber;
            this.AccountName = accountName;
            this.Balance = balance;
            this.Address = address;
        }
        public int AccountNumber
        {

            set { accountNumber = value; }
            get { return accountNumber; }
        }
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
            if (amount > 0 && amount <= this.balance)
            {
                this.Balance = this.Balance - amount;
                Console.WriteLine("Withdraw Successful");
            }
            else
            {
                Console.WriteLine("Balance not found");
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
            this.Address.GetAddress();
        }

        internal void Transfer(int amount, int receiver)
        {
            throw new NotImplementedException();
        }
    }
}
