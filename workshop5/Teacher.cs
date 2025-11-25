namespace workshop5
{
    public class Teacher
    {
        // Property for teacher name
        public string Name { get; set; }

        // Constructor
        public Teacher(string name)
        {
            Name = name;
        }

        // Virtual method so child classes can override
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Method that cannot be overridden — sealed
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary is confidential.");
        }
    }
}
