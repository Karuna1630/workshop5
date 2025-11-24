namespace workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456", 1000);

          
            Console.WriteLine("Account Number:" + account.AccountNumber);

            account.Deposit (1111.1); 
            account.Withdraw(500);
            Console.WriteLine("Remaining Balance: " + account.Balance);
        }
    }
}
