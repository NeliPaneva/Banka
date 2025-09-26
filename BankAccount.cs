
namespace Banka
{
    class BankAccount
    {
       private decimal balance;
       private string name;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
