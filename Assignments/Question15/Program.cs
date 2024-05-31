using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLib;
namespace Question15
{
    internal class Program
    {
        static int Menu()
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Add Company name and address");
            Console.WriteLine("2. Display Company Details");
            Console.WriteLine("3. Add Employee");
            Console.WriteLine("4. Remove Employee");
            Console.WriteLine("5. Find Employee");
            Console.WriteLine("6. Print Employees");
            Console.Write("Enter choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int choice;
            int id;
            Company company = new Company();

            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Menu Exited");
                        break;
                    case 1:
                        company.Accept();
                        break;
                    case 2:
                        company.Display();
                        break;
                    case 3:
                        Employee employee = new Employee();
                        employee.Accept();
                        company.AddEmployee(employee);
                        break;
                    case 4:
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (company.RemoveEmployee(id))
                        {
                            Console.WriteLine("Employee removed");
                        }
                        else
                        {
                            Console.WriteLine("Employee not found");
                        };
                        break;
                    case 5:
                        Console.Write("Enter id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        LinkedListNode<Employee> ln = company.FindEmployee(id);
                        if (ln == null)
                        {
                            Console.WriteLine("Employee not found");
                        }
                        else
                        {
                            ln.Value.Display();
                        }
                        break;
                    case 6:
                        company.PrintEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            } while (choice != 0);
        }
    }
}
