using EmpLib;
using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
namespace Question16
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
            Console.WriteLine("7. Save File");
            Console.WriteLine("8. Load File");
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
                    case 7:
                        FileStream fs = new FileStream(@"C:\Users\vaish\OneDrive\Desktop\grabage\files\text5.txt", FileMode.OpenOrCreate, FileAccess.Write);
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, company);
                        bf = null;
                        fs.Close();
                        break;
                    case 8:
                        if (File.Exists(@"C:\Users\vaish\OneDrive\Desktop\grabage\files\text5.txt"))
                        {
                            FileStream fs2 = new FileStream(@"C:\Users\vaish\OneDrive\Desktop\grabage\files\text5.txt", FileMode.Open, FileAccess.Read);
                            BinaryFormatter bf2 = new BinaryFormatter();
                            object obj = bf2.Deserialize(fs2);
                            if(obj is Company)
                            {
                                company = (Company)obj;
                            }
                            fs2.Close();

                        }
                        else
                        {
                            Console.WriteLine("File doesn't exists");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            } while (choice != 0);
        }
    }
}
