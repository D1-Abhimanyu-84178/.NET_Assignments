using Question8_EmpDept;
using System.Xml.Serialization;

namespace Question12_Company
{
    internal class Program
    {
        public static int menu()
        {
            Console.WriteLine("0.Exit");
            Console.WriteLine("1. AddEmployee ");
            Console.WriteLine("2. Remove Employee");
            Console.WriteLine("3. Find Employee");
            Console.WriteLine("4. Print Employee");
            return Convert.ToInt32(Console.ReadLine()); 
        }
        static void Main(string[] args)
        {

           Company company = new Company();
            company.Accept();
            company.Print();
            int choice = 0;
            do
            {
                switch(choice)
                {
                    case 0:
                        break;
                    case 1:
                        Employee e = new Employee();
                        e.Accept();
                        company.AddEmployee(e);
                        break;
                    case 2:
                        Console.WriteLine("Enter Employee Id to Remove");
                        choice = Convert.ToInt32(Console.ReadLine());
                        company.RemoveEmployee(choice);
                        break;
                    case 3:
                        Console.WriteLine("Enter Employee ID to Find Employee");
                        choice = Convert.ToInt32(Console.ReadLine());
                        company.FindEmployee(choice);
                        break;
                    case 4:
                        Console.WriteLine("Printing Employees...");
                        company.PrintEmployees();
                        break;
                    default: Console.WriteLine("Invalid Choice...");
                        break;
                }
            }while ((choice = menu()) != 0);
        }
    }
}
