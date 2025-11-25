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

            ////Task 2:
            ////create Car object
            //Car myCar = new Car("Toyota", 180, 5);
            //Motorcycle myMotorcycle = new Motorcycle("Honda", 150, 600);


            ////demostrate Car methods
            //Console.WriteLine("Car Information:");
            //myCar.Start();
            //myCar.DisplayCarInfo();
            //myCar.Stop();

            //Console.WriteLine();

            ////Demostrate Motorcycle
            //Console.WriteLine("Motorcycle Information:");
            //myMotorcycle.Start();
            //myMotorcycle.DisplayInfo();
            //myMotorcycle.Stop();

            ////Task 3:--------------------------------
            ////---------polymorphism with method overloading---------
            //// Create Printer object
            //Printer myPrinter = new Printer();

            //// Call Print(string)
            //Console.WriteLine("=== Print(string) ===");
            //myPrinter.Print("My name is karuna Giri");

            //// Call Print(int)
            //Console.WriteLine("\n=== Print(int) ===");
            //myPrinter.Print(21);

            //// Call Print(string, int)
            //Console.WriteLine("\n=== Print(string, int) ===");
            //myPrinter.Print("Repeat this message", 2);

            //Task 5
            // Create an object of NepaliTeacher and pass name to constructor
            NepaliTeacher nepali = new NepaliTeacher("Ram");
            // Create an object of EnglishTeacher and pass name to constructor
            EnglishTeacher english = new EnglishTeacher("John");

            Console.WriteLine("--- Nepali Teacher ---");
            // Calls the overridden Teaching() method from NepaliTeacher class
            nepali.Teaching();
            // Calls SalaryInfo() method (inherited from Teacher and cannot be overridden)
            nepali.SalaryInfo();

            Console.WriteLine("\n--- English Teacher ---");
            // EnglishTeacher does NOT override Teaching(), so parent class method runs
            english.Teaching();   // Uses base class method
            // SalaryInfo() is inherited from Teacher class
            english.SalaryInfo();

        }
    }
}
