using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Xml;
using System.Xml.Linq;

namespace Question4_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
        }
    }

    public struct Student
    {
        public string name { get; set; }
        public bool gender {  get; set; }
        public int age { get; set; }
        public int std { get; set; }
        public char div {  get; set; }
        public double marks { get; set; }


        public Student()
        {
        name = string.Empty;
        gender = false;
        age = 0;
        std = 0;
        div = 'a';
        marks = 0;

        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
           this.name = name;
           this.gender = gender;
           this.age = age;
           this.std = std;  
           this.div = div;
           this.marks = marks; 
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Studnet name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter student gender: ");
            char Inputgender = Convert.ToChar(Console.ReadLine());
            if (Inputgender == 'M')
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            Console.WriteLine("Enter age of Student");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter std of Student");
            std = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Division of student");
            div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter marks of student ");
            marks = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "["+ " name : " + name + " gender: " + gender + " marks " + marks + "]";
        }
        public void PrintDetails()
        {

  
        Console.WriteLine(ToString());
            Console.WriteLine("name : " + name);
           
            if (gender)
            {
                Console.WriteLine("gender : " + "Male");
            }
            else
            {
                Console.WriteLine("gender : " + "Female");
            }
            Console.WriteLine("age : " + age);
            Console.WriteLine("std : " +  std);
            Console.WriteLine("div : " + div);
            Console.WriteLine("makrs : " + marks);
            Console.ReadLine();
        }
    }
}
