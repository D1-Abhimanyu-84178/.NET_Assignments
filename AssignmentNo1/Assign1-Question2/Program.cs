using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Assign1_Question2
{
    internal class Program
    {
        public static double addNumber(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double subNumber(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double mulNumber(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double divNumber(double num1,double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            double num1, num2;
            int choice  = 0;
            Console.WriteLine("Enter Number: 1");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number: 2");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("Enter you choice..");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    
                    Console.WriteLine("The addition of Two numbers is : " + addNumber(num1, num2));
                    break;
                case 2: Console.WriteLine("the Subtraction of two numbers is : " + subNumber(num1, num2) );
                    break;
                case 3: Console.WriteLine("The Multiplication of two numbers is : " + mulNumber(num1, num2));
                    break;
                case 4: Console.WriteLine("The Division of two numbers is: " + divNumber(num1, num2));   
                    break;
            }

        }
    }
}
