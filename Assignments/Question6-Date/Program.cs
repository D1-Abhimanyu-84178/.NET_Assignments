namespace Question6_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.AcceptDate();
            date.PrintDate();

            bool check = date.IsValid();
            if(check )
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is invalid");
            }

            Console.WriteLine(date.ToString());
        }
    }
}
