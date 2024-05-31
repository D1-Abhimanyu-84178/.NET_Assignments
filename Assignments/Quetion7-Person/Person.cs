using Question6_Date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quetion7_Person
{

    public class Person
    {
        // Properties
        private Date _date;

        public Date DATE
        {
           get { return _date; }
           set { _date = value; }
        }
        
        public string Name { get; set; }
        public string Gender { get; set; }

        
        public string Address { get; set; }

        // Read-only property for Age
        public int Age
        {
            get
            {
                DateTime date = DateTime.Now;
                return  Date.checkDifference(_date, date);
            }
        }

        // Default constructor
        public Person()
        {
            DATE = new Date();
        }

        // Parameterized constructor
        public Person(string name, string gender, int day, int month, int year, string address)
        {
            Name = name;
            Gender = gender;
            //DATE= birth;
            DATE = new Date(day, month, year);
            Address = address;
        }

        // Method to accept data from console
        public void Accept()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gender: ");
            Gender = Console.ReadLine();

            Console.Write("Enter Birth Date (yyyy-mm-dd): ");
            DATE.AcceptDate();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();
        }

        // Method to print data to console
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            DATE.PrintDate();
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Age: {Age}");
        }

        // Override ToString method to return data of object in string format
        public override string ToString()
        {
            return $"Name: {Name}, Gender: {Gender}, Birth Date: {DATE.ToString()}, Address: {Address}, Age: {Age}";
        }
    }

}
