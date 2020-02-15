using System;
using BankKata.Lib;

namespace BankKata
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransactionsRepo transactionsRepo = new TransactionsRepo();
            IBankClock clock = new BankClock();
            IBankConsole console = new BankConsole();
            ITransactionPrinter transactionPrinter = new BankPrinter(console);
            var account = new BankAccount(transactionsRepo, clock, transactionPrinter);

            account.Deposit(1500);
            account.Withdraw(500);
            account.Deposit(300);
            account.Deposit(300);

            account.PrintStatement();
        }
    }
}

