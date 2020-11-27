using System;
using BankKata.Lib;
using BankKata.Out.Lib;

namespace BankKata
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransactionsRepo transactionsRepo = new TransactionsRepo();
            IBankClock clock = new BankClock();
            ITransactionPrinter transactionPrinter = new SpectrePrinter();
            var account = new BankAccount(transactionsRepo, clock, transactionPrinter);

            account.Deposit(1500);
            account.Withdraw(500);
            account.Deposit(300);
            account.Deposit(300);

            account.PrintStatement();
        }
    }
}

