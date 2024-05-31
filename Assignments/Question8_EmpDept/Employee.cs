using Question6_Date;
using Quetion7_Person;


namespace Question8_EmpDept
{

    public enum DepartmentType
    {
        HR, 
        IT, 
        Finance, 
        Marketing, 
        Sales
    }
    public class Employee : Person
    {
       public  int Id {  get; set; }
       public double Salary { get; set; }

       public string Designation { get; set; }
       public DepartmentType Dept {  get; set; }

        public static int _idCounter;

       //public Person Person { get; set; }
       public Employee()
        {
            
        }

        // Constructor
        public Employee(double salary, string designation, DepartmentType dept, string name, string gender,int day,int month, int year, string address) : base(name, gender, day, month, year, address)
        {
            Id = _idCounter;
            Salary = salary;
            Designation = designation;
            Dept = dept;
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Salary : {Salary}");
            Console.WriteLine($"Designation : {Designation}");


        }

        protected void AcceptComman()
        {
            base.Accept();
            Console.WriteLine("Enter Id of Employee :  ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary of Employee : ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Department of Employee : ");
            string[] dp = Enum.GetNames<DepartmentType>();
            Console.WriteLine("Enter Dept Type : ");
            foreach(string department in dp)
            {
                Console.WriteLine($"{department}");
            }
           string newDept = Console.ReadLine().ToUpperInvariant();
           Dept = (DepartmentType)Enum.Parse(typeof(DepartmentType), newDept);

        }

        public void acceptDesignation()
        {
            AcceptComman();
            Console.WriteLine("Enter Designation of Employee : ");
            Designation = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"ID: {Id}, Salary: {Salary}, Designation: {Designation}, Department: {Dept}";
        }
    }
}
