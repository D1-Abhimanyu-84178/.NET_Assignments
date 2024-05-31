using Question8_EmpDept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Question9_Supervisor
{
    public class Supervisor : Employee
    {
        public int Subbordinates { get; set; }

       public Supervisor()
        {
            Designation = "Supervisor";
        } 

        public Supervisor(double salary, string designation, DepartmentType dept, string name, string gender, int day, int month, int year, string address, int subbordinates) : base(salary,"Supervisor", dept, name, gender, day, month, year, address)
        {
            this.Subbordinates = subbordinates;
        }

        public void AcceptComman()
        {
            //base.Accept();
            base.AcceptComman();
            Console.WriteLine("Enter the no of assistants: ");
            Subbordinates = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Subbordinates: {Subbordinates}");
        }
    }
}
