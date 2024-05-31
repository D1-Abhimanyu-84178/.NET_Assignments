namespace Quetion7_Person
{
    internal class Program
    {
        public static void Main()
        {
            // Using default constructor
            Person person1 = new Person();
            person1.Accept();
            person1.Print();
            Console.WriteLine(person1.ToString());

            // Using parameterized constructor
            Person person2 = new Person("Alice", "Female", 23, 5, 1990, "1234 Main St");
            person2.Print();
            Console.WriteLine(person2.ToString());
        }
    }
}


