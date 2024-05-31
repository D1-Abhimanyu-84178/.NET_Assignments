using Question8_EmpDept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9_Manager
{
    public class Manager : Employee
    {
     public double Bonus
        {
            get; set;
        }

     public Manager(double salary, DepartmentType dept, string name, string gender, int day, int month, int year, string address, int bonus) : base(salary, "Manager", dept, name, gender, day, month, year, address)
     { 
            Bonus = bonus;
            Designation = "Manager";   
     }

     public Manager()
        {
            Designation = "Manager";
        }


        public void AcceptComman()
        {
            base.AcceptComman();
            Console.WriteLine("Enter the bonus: ");
            Bonus = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Subbordinates: {Bonus}");
        }
    }


}
