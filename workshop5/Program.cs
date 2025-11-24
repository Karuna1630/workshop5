namespace workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1:
            //    BankAccount account = new BankAccount("123456", 1000);


            //    Console.WriteLine("Account Number:" + account.AccountNumber);

            //    account.Deposit (1111.1); 
            //    account.Withdraw(500);
            //    Console.WriteLine("Remaining Balance: " + account.Balance);
            //

            //Task 2:
            //create Car object
            Car myCar = new Car("Toyota", 180, 5);
            Motorcycle myMotorcycle = new Motorcycle("Honda", 150, 600);


            //demostrate Car methods
            Console.WriteLine("Car Information:");
            myCar.Start();
            myCar.DisplayCarInfo();
            myCar.Stop();

            Console.WriteLine();

            //Demostrate Motorcycle
            Console.WriteLine("Motorcycle Information:");
            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();




        }
    }
}
