using System.Collections.Generic;

namespace BankKata.Lib
{
    public class TransactionsRepo : ITransactionsRepo
    {
        public IList<Transaction> AllTransactions() {
            throw new System.NotImplementedException();
        }

        public void AddDepositTransaction(string date, int amount)
        {
            throw new System.NotImplementedException();
        }

        public void AddWithdrawlTransaction(string date, int amout)
        {
            throw new System.NotImplementedException();
        }
    }
}