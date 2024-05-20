using System;
using System.Diagnostics;

namespace Question5_Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To create array enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            Student[] students  = Student.CreateArray(size);
            Student.AcceptInfo(students);
            Student.PrintInfo(students);
            Student.ReverseArray(students);
            


        }
    }

    #region  'our struct is here'
    // our struct is here
    public struct Student { 
    public string name { get; set; }
    public bool gender { get; set; }
    public int age { get; set; }
    public int std { get; set; }
    public char div { get; set; }
    public double marks { get; set; }

    static Student[] students;

    // Note: No need for a parameterless constructor, as struct fields are automatically initialized to default values
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
            return $"[Name: {name}, Gender: {(gender ? "Male" : "Female")}, Age: {age}, Std: {std}, Div: {div}, Marks: {marks}]";

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
        Console.WriteLine("std : " + std);
        Console.WriteLine("div : " + div);
        Console.WriteLine("makrs : " + marks);
    }
        public static Student[] CreateArray(int size)
        {
            Student[] students = new Student[size];
            //for (int i = 0; i<students.Length; i++)
            //{
            //    students.
            //}
            return students; 
        }
        public static void AcceptInfo(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
            {
                //students[i] = new Student();
                students[i].AcceptDetails();

            }

            Console.WriteLine("Studnet List completed");
        }

        public static void PrintInfo(Student[] students)
        {
            foreach (Student item in students)
            {
               item.PrintDetails();
            }
        }

        public static void ReverseArray(Student[] students)
        {
            Student[] newList = students.Reverse().ToArray();
            Student.PrintInfo(newList);
        }
    }
}
#endregion
#region class student
//public class Student
//{
//    public string Name { get; set; }
//    public int rollno { get; set; }
//    public int std {  get; set; }
//    public char div { get; set; }
//    public double marks {  get; set; } 
//    public Student() {
//    Name = string.Empty;
//    rollno = 0;
//    std = 0;
//    div = (char)(0);
//    marks = 0;
//    }

//    public Student(string name, int rollno, int std, char div, double marks)
//    {
//        this.Name = name;
//        this.rollno = rollno;
//        this.std = std;
//        this.div = div;
//        this.marks = marks;
//    }


//    public static void CreateArray(int size)
//    {
//        Student[] students = new Student[size];

//    }

//    public static void AcceptInfo(Student[] students)
//    {
//        for (int i = 0; i < students.Length; i++)
//        {
//            Console.WriteLine("Enter the name of student");
//            students[i].Name = Console.ReadLine();
//            Console.WriteLine("Enter the roll no of student");
//            students[i].rollno  = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the std of student");
//            students[i].std = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the marks of student");
//            students[i].marks = Convert.ToDouble(Console.ReadLine());

//        }

//        Console.WriteLine("Studnet List completed");
//    }

//    public static void PrintInfo(Student[] students )
//    {
//        foreach (Student item in students)
//        {
//            Console.WriteLine("Name of Student: " + item.Name);
//            Console.WriteLine("div : " + item.div);
//        }
//    }
//}

#endregion