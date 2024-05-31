using System.Xml.Serialization;
using EmpLib;
namespace Question18
{
    delegate double MyDelegate(double x,double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Multicast();
        }
        static void Unicast()
        {
            MyDelegate unicast;
            int choice;
            double a, b;
            Console.Write("Enter the value of a and b: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            do
            {

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Change a and b");
                Console.Write("Enter choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        unicast = new MyDelegate(MathStatic.Add);
                        Console.WriteLine($"{a} + {b} = {unicast(a, b)}");
                        break;
                    case 2:
                        unicast = new MyDelegate(MathStatic.Subtract);
                        Console.WriteLine($"{a} - {b} = {unicast(a, b)}");
                        break;
                    case 3:
                        unicast = new MyDelegate(MathStatic.Multiply);
                        Console.WriteLine($"{a} * {b} = {unicast(a, b)}");
                        break;
                    case 4:
                        unicast = new MyDelegate(MathStatic.Divide);
                        Console.WriteLine($"{a} / {b} = {unicast(a, b)}");
                        break;
                    case 5:
                        Console.Write("Enter the value of a and b: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);

        }
        static void Multicast()
        {
            MyDelegate multiCast=null;
            int choice;
            double a, b;
            Console.Write("Enter the value of a and b: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            do
            {

                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Change a and b");
                Console.Write("Enter choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        multiCast += MathStatic.Add;
                        Console.WriteLine($"{a} + {b} = {multiCast(a, b)}");
                        break;
                    case 2:
                        multiCast = new MyDelegate(MathStatic.Subtract);
                        Console.WriteLine($"{a} - {b} = {multiCast(a, b)}");
                        break;
                    case 3:
                        multiCast = new MyDelegate(MathStatic.Multiply);
                        Console.WriteLine($"{a} * {b} = {multiCast(a, b)}");
                        break;
                    case 4:
                        multiCast = new MyDelegate(MathStatic.Divide);
                        Console.WriteLine($"{a} / {b} = {multiCast(a, b)}");
                        break;
                    case 5:
                        Console.Write("Enter the value of a and b: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        b = Convert.ToDouble(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 0);

        }
    }
    public static class MathStatic
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
        public static double Divide(double x, double y)
        {
            return x / (double)y;
        }

    }
    public class Maths
    {
        public Maths()
        {

        }
        public  double Add(double x, double y)
        {
            return x + y;
        }
        public  double Subtract(double x, double y)
        {
            return x - y;
        }
        public  double Multiply(double x, double y)
        {
            return x * y;
        }
        public  double Divide(double x, double y)
        {
            return x / (double)y;
        }
    }
}
