using System.Collections.Generic;

namespace BankKata.Lib
{
    public class TransactionsRepo : ITransactionsRepo
    {
        private readonly IList<Transaction> transactions;

        public TransactionsRepo() {
            transactions = new List<Transaction>();
        }

        public IList<Transaction> AllTransactions() {
            return transactions;
        }

        public void AddDepositTransaction(string date, int amount)
        {
            
        }

        public void AddWithdrawlTransaction(string date, int amout)
        {
            throw new System.NotImplementedException();
        }
    }
}