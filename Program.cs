namespace Banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            BankAccount a1 = new BankAccount();
            Console.WriteLine(a1.Name);
            Console.WriteLine(a1.Balance);
            a1.Name = "Stoian";
            a1.Balance = 120.25m;
            Console.WriteLine(a1.Name);
            Console.WriteLine(a1.Balance);

        }
    }
}
