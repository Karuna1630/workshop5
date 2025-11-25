namespace workshop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 1:
            //BankAccount myAccount = new BankAccount();
            //Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            //myAccount.Deposit(1000);
            //myAccount.Withdraw(500);
            //Console.WriteLine($"Remaining Balance: {myAccount.Balance}");

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

            //Printer printer = new Printer();
            //printer.Print("HI MY NAME IS KARUNA");
            //printer.Print(52);
            //printer.Print("this is workshop", 5);



        }
    }
}
