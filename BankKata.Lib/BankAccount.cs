using System;

namespace BankKata.Lib
{
    public class BankAccount
    {
        private ITransactionsRepo transactionsRepo;

        public BankAccount(ITransactionsRepo transactionsRepo)
        {
            this.transactionsRepo = transactionsRepo;
        }

        public virtual void Deposit(int amount) {
            
        }

        public virtual void Withdraw(int amount)
        {
            
        }

        public virtual void PrintStatement()
        {
            
        }
    }
}
