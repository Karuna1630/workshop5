using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    internal class BankAccount
    {
        //creating private fields
        private string accountNumber;
        private decimal balance;

        //creating public properties 
        public string AccountNumber
         {
            get { return accountNumber; }
         }

        //Balance with a condition and setter is private 
        public decimal Balance
        {
            get { return balance; }
            private set
            {
                //validating that balance is greater than 0
                if (value > 0)
                {
                    balance = value;
                }
                else
                {
                   throw new ArgumentException("Balance must be greater than 0.");
                }
            }
        }

        //Method for depositing money into the account
        public void Deposit(decimal amount)
        {
            //account must be positive
            if (amount > 0)
            {
                //adding amount to balance
                Balance += amount;
               
            }
            else
            {
               
               throw new ArgumentException("Deposit amount must be greater than 0.");
            }
        }

        //Method for withdrawing money from the account
        public void Withdraw(decimal amount)
        {
            //amount must be positive and less than or equal to balance
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else 
            {
              throw new ArgumentException("Withdrawal amount must be greater than 0 and less than or equal to the current balance.");
            }
           
        }
    }



   
}
