namespace BankKata.Lib
{
    public class Transaction
    {
        public Transaction(string date, int amount)
        {
            this.Date = date;
            this.Amount = amount;
        }

        public string Date { get; set; }
        public int Amount { get; set; }
    }
}