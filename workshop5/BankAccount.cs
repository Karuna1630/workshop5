using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

         public string AccountNumber
         {
            get { return this.accountNumber; }
         }
        public double Balance
        {
            get { return this.balance; }
            private set
            {
                if (value <= 0)
                {
                     Console.WriteLine("Balance must be positive.");
                }
                else
                {
                    this.balance = value;
                }
            }
        } 
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            if(initialBalance <= 0)
            {
                Console.WriteLine("Initial balance must be positive. Setting balance to 0.");
                this.balance = 0;
            }
            else
            {
                this.balance = initialBalance;
            }
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                this.Balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
               
                Console.WriteLine($"Deposited must be greater than 0");
            }
        }


        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than 0.");
            }
            else if (amount > this.Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                this.Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}");
            }
        }
    }



   
}
