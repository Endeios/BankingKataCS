using System.Collections.Generic;

namespace BankKata.Lib
{
    public class BankAccount
    {
        private ITransactionsRepo transactionsRepo;
        private IBankClock clock;
        private ITransactionPrinter transactionPrinters;

        public BankAccount(ITransactionsRepo transactionsRepo,
                           IBankClock clock, ITransactionPrinter transactionPrinter)
        {
            this.transactionsRepo = transactionsRepo;
            this.clock = clock;
            this.transactionPrinters = transactionPrinter;
        }

        public virtual void Deposit(int amount)
        {
            transactionsRepo.AddDepositTransaction(GetCurrentDate(), amount);
        }

        private string GetCurrentDate()
        {
            return clock.GetCurrentDateAsString();
        }

        public virtual void Withdraw(int amount)
        {
            transactionsRepo.AddWithdrawlTransaction(GetCurrentDate(), amount);
        }

        public virtual void PrintStatement()
        {
            IList<Transaction> transactions = transactionsRepo.AllTransactions();
            transactionPrinters.PrintTransactions(transactions);
        }
    }
}
