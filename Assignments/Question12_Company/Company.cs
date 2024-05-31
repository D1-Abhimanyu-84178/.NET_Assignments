using Question8_EmpDept;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question12_Company
{
    public class Company
    {
        public string Name { get; set; }
        public string Address {  get; set; }

        public LinkedList<Employee> empList { get; set; }

        public double SalaryExpense {  get; set; }

        public Company() {
        empList = new LinkedList<Employee>();
        }

        public Company(string name, string address, LinkedList<Employee> empList, double salaryExpense) 
        {
            this.Name = name;
            Address = address;
            this.empList = empList;
            SalaryExpense = salaryExpense;
        }

        public void Accept()
        {
            Console.WriteLine("Enter name of Company : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address of Comapny: ");
            Address = Console.ReadLine();
            Console.WriteLine("Enter employees...");
            char choice = ' ';
            while (choice.ToString().ToUpper() != "N")
            {
                Employee emp = new Employee();
                emp.acceptDesignation();
                empList.AddFirst(emp);
                Console.WriteLine("Do you Still want to add Employee y/n");
                choice =Convert.ToChar(Console.ReadLine());
            }
        }

        public void Print()
        {
            Console.WriteLine("Name of Company : " + Name.ToUpper());
            Console.WriteLine("Address of Company : " + Address.ToUpper()); 
            Console.WriteLine("Employees Present in Company : ");
            PrintEmployees();
            Console.WriteLine("Salary Expense : " + CalculateSalaryExpense());
        }

        public double CalculateSalaryExpense()
        {
            foreach(Employee emp in empList)
            {
                SalaryExpense += emp.Salary;
            }
            return SalaryExpense;
        }

        public void PrintEmployees()
        {
            foreach (Employee emp in empList)
            {
                emp.Print();
            }
        }

        public void AddEmployee(Employee e)
        {
            e.Accept();
            empList.AddLast(e);
        }

        public bool RemoveEmployee(int id)
        {
            
            foreach( Employee emp in empList)
            {
                if (emp.Id == id)
                {
                    empList.Remove(emp);
                    return true;
                }
                
            }
            return false;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            foreach(Employee e in empList)
            {
                if(e.Id == id)
                {
                    return empList.Find(e);
                }
            }
                return null;
        }

        public override string ToString() {
            return $"Name : {Name}, Address {Address}, ListOfEmp{empList}";
        }
    }
}
