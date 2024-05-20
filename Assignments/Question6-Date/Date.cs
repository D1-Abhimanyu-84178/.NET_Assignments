global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Contracts;

namespace Question6_Date
{
    public class Date
    {
        private int day;
        private int year;
        private int month;

        public Date()
        {

        }

        public Date(int day, int year, int month)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void AcceptDate()
        {
            Console.WriteLine("Enter day: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year: ");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintDate()
        {
            Console.WriteLine($"Date: {day}/{month}/{year}");
        }

        public bool IsValid()
        {
            if(day <= 31 && month <=12)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "["+ "Day: " +day + "Month : " + month + "Year : "+ year +"]";
        }
    }
}


