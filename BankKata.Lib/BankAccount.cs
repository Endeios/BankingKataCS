using System;

namespace BankKata.Lib
{
    public class BankAccount
    {
        private ITransactionsRepo transactionsRepo;
        private IBankClock clock;

        public BankAccount(ITransactionsRepo transactionsRepo,
                           IBankClock clock)
        {
            this.transactionsRepo = transactionsRepo;
            this.clock = clock;
        }

        public virtual void Deposit(int amount) {
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
            
        }
    }
}
