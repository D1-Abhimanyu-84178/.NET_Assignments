namespace Question8_EmpDept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(50000, "Software Engineer", DepartmentType.IT, "John Doe", "Male", 15, 6, 1985, "1234 Elm Street");
            
            Employee emp2 = new Employee();
            emp2.Accept();

            Console.WriteLine("Both the Employees are : ");
            emp1.Print();
            emp2.Print();
        }
    }
}
