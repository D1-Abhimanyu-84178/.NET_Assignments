using Question6_Date;
using Question8_EmpDept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WageEmp
{
    public class WageEmp : Employee
    {
        public int Hours { get; set; }

        public int rate {  get; set; }

        public WageEmp(double salary, DepartmentType dept, string name, string gender, int day, int month, int year, string address, int hrs, int rate) : base(salary, "WageEmp", dept, name, gender, day, month, year, address)
        {
            Designation = "WageEmp";
            Hours = hrs;
            rate = rate;
            salary = Hours * rate;
        }

        public WageEmp()
        {
            Designation = "WageEmp";

        }

        public void AcceptComman()
        {
            base.AcceptComman();
            Console.WriteLine("Enter the Hours: ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate: ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Hours: {Hours}");
            Console.WriteLine($"Rate: {rate}");
        }

        public override string ToString()
        {
            return $"ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}, Hours : {Hours}, Rate : {rate} ,  Date : {DATE}";
        }
    }
}
