using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private Double balance;
        private Address address;

        public Account(int accountNumber, string accountName, double balance, Address address)
        {
            this.AccountNumber = accountNumber;
            this.AccountName = accountName;
            this.Balance = balance;
            this.Address = address;
        }
        public int AccountNumber
        {

            set { this.accountNumber = value; }
            get { return this.accountNumber; }
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
            if (this.Balance - amount >= 500)
            {
                this.Balance = this.Balance - amount;
            }
            else
            {
                Console.WriteLine("Insufficiant Balance");
            }
        }
        public void Deposit(double amount)
        {
            this.Balance = this.Balance + amount;
        }
        public void Transfer(double amount, Account receiver)
        {

            this.Withdraw(amount);
            receiver.Deposit(amount);
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNumber, this.accountName, this.balance);
            this.Address.GetAddress();
        }

    }
}
