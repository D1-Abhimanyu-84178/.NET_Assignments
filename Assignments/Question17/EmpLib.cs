using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

    namespace Question17
    {

        public enum MyEnum
        {
            MARKETTING,
            OPERATIONS,
            TECHNOLOGY
        }
        [Serializable]
        public class Person
        {
            public Person()
            {
                Birth = new Date();
            }
            public Person(string name, string add, Date birth)
            {
                this.Name = name;
                this.Birth = birth;
                this.Address = add;
            }
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            private string _address;

            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            private Date _birth;

            public Date Birth
            {
                get { return _birth; }
                set { _birth = value; }
            }
            private bool _gender;

            public bool Gender
            {
                get { return _gender; }
                set { _gender = value; }
            }
            public int Age
            {


                get
                {
                    Date tdy = new Date(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                    return (tdy - Birth);
                }
            }
            public virtual void Accept()
            {
                Console.Write("Enter name:");
                Name = Console.ReadLine();
                Console.Write("Enter gender(M/F):");
                Gender = Convert.ToBoolean(Console.ReadLine() == "M" ? true : false);
                Console.Write("Enter address:");
                Address = Console.ReadLine();
                Birth.AcceptDate();
            }
            public virtual void Display()
            {
                Console.WriteLine(this);
            }
            public override string ToString()
            {
                return "Name: " + Name + "\nAddress: " + Address + "\nGender: " + (Gender ? "M" : "F") + "\nDOB: " + Birth + "\nAge: " + Age;
            }
        }
        [Serializable]
        public class Date
        {
            private int _day;
            public Date() { }
            public Date(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public int Day
            {
                get { return _day; }
                set { _day = value; }
            }
            private int _month;

            public int Month
            {
                get { return _month; }
                set
                { _month = value; }

            }
            private int _year;

            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }
            public override string ToString()
            {
                return Day + "/" + Month + "/" + Year;
            }
            public void AcceptDate()
            {
                Console.Write("Enter day for DOB:");
                Day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter month for DOB:");
                Month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter year for DOB:");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            public void DisplayDate()
            {
                Console.WriteLine(this);
            }
            public bool isValid()
            {
                DateTime dateValue;
                return DateTime.TryParse(this.ToString(), out dateValue);
            }
            public static int operator -(Date d1, Date d2)
            {
                return Math.Abs(d1.Year - d2.Year);
            }
        }
        [Serializable]
        public class Employee : Person,IComparable<Employee>
        {
            public Employee()
            {
                Id = Generate();
            }
            public Employee(MyEnum dept, string desgn, double salary, string name, Date birth, string addr) : base(name, addr, birth)
            {
                Dept = dept;
                this._desgn = desgn;
                Salary = salary;
                Id = Generate();
            }
            private int _id;
            private static int auto = 1;
            private static int Generate()
            {
                return auto++;
            }
            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            private MyEnum _dept;

            public MyEnum Dept
            {
                get { return _dept; }
                set { _dept = value; }
            }
            private double _salry;

            public double Salary
            {
                get { return _salry; }
                set { _salry = value; }
            }
            private string _desgn;

            public string Designation
            {
                get { return _desgn; }
                set { _desgn = value; }
            }
            public override void Accept()
            {
                base.Accept();
                Console.Write("Enter salary: ");
                Salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter department 0.Marketing 2.Operations 3.Technology: ");
                int choice = Convert.ToInt32((Console.ReadLine()));
                switch (choice)
                {
                    case 0:
                        Dept = MyEnum.MARKETTING;
                        break;
                    case 1:
                        Dept = MyEnum.OPERATIONS;
                        break;
                    case 2:
                        Dept = MyEnum.TECHNOLOGY;
                        break;
                }
            }
            public override void Display()
            {
                System.Console.WriteLine(this);
            }
            public override string ToString()
            {
                return "Id: " + Id + "\n" + base.ToString() + "\nSalary: " + Salary + "\nDesignation: " + Designation + "\n Department:" + Dept;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj is Employee)
                {
                    Employee eTemp = (Employee)obj;
                    return eTemp.Id == this.Id;
                }
                return false;
            }

            public int CompareTo(Employee obj)
            {   
                return Id.CompareTo(obj.Id);
            }
        }
        [Serializable]
        public class Company
        {
            private string _name;
            private string _address;
            private ArrayList _empList;
            double _salaryExpense;
            public Company()
            {
                _empList = new ArrayList();
            }
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }

            public double SalaryExpenses
            {
                get { return _salaryExpense; }
            }
            public ArrayList EmpList
            {
                get { return _empList; }
            }
            public Company(string name, string address)
            {
                Name = name;
                Address = address;
                _empList = new ArrayList();
            }
            public void Accept()
            {
                Console.Write("Enter Company Name: ");
                Name = Console.ReadLine();
                Console.Write("Enter Company Address: ");
                Address = Console.ReadLine();
            }
            public void Display()
            {
                Console.WriteLine(this);
            }
            private void CalculateSalaryExpense()
            {
                _salaryExpense = 0;
                foreach (Employee emp in EmpList)
                {
                    _salaryExpense += emp.Salary;
                }
            }
            public void AddEmployee(Employee e)
            {
                EmpList.Add(e);
            }
            public bool RemoveEmployee(int id)
            {
                Employee e = new Employee();
                e.Id = id;
                if (EmpList.IndexOf(e) >= 0)
                {
                    EmpList.Remove(e);
                    return true;
                }
                return false;
            }
            public int FindEmployee(int id)
            {
                Employee e = new Employee();
                e.Id = id;
                 return EmpList.IndexOf(e);   
                 }
            public void PrintEmployees()
            {
                foreach (Employee emp in EmpList)
                {
                    Console.WriteLine(emp);
                }
            }
            public override string ToString()
            {
                CalculateSalaryExpense();
                string s1 = "\nName: " + Name + "\nCompany: " + Address + "\nSalary Expenses: " + SalaryExpenses;
                return s1;
            }
        }

    }

