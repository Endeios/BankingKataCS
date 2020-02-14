namespace BankKata.Lib
{
    public interface ITransactionsRepo
    {
        void addDepositTransaction(string date, int amount);
    }
}