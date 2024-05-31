namespace WageEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp wageEmp = new WageEmp();
            wageEmp.AcceptComman();
            wageEmp.Print();
           Console.WriteLine(wageEmp.ToString());
        }
    }
}
