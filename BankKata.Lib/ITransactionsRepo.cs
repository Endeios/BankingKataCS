namespace BankKata.Lib
{
    public interface ITransactionsRepo
    {
        void AddDepositTransaction(string date, int amount);
        void AddWithdrawlTransaction(string date, int amout);
    }
}