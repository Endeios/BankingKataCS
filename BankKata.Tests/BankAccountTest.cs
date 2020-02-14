using BankKata.Lib;
using FakeItEasy;
using NUnit.Framework;
using System.Collections.Generic;

namespace BankKata.Tests
{
    public class BankAccountTest
    {
        private const string DATE = "14/02/2020";
        private BankAccount account;
        private ITransactionsRepo transactionsRepo;
        private IBankClock clock;
        private ITransactionPrinter printer;

        [SetUp]
        public void Setup()
        {
            transactionsRepo = A.Fake<ITransactionsRepo>();
            clock = A.Fake<IBankClock>();
            printer = A.Fake<ITransactionPrinter>();
            account = new BankAccount(transactionsRepo, clock, printer);
        }

        [Test]
        public void should_store_deposit_transactions_in_a_repo()
        {
            A.CallTo(() => clock.GetCurrentDateAsString()).Returns(DATE);
            account.Deposit(500);

            A.CallTo(() => transactionsRepo.AddDepositTransaction(DATE, 500)).MustHaveHappened();
        }

        [Test]
        public void should_store_withdrawl_transactions_in_a_repo()
        {
            A.CallTo(() => clock.GetCurrentDateAsString()).Returns(DATE);
            account.Withdraw(500);

            A.CallTo(() => transactionsRepo.AddWithdrawlTransaction(DATE, 500)).MustHaveHappened();
        }

        [Test]
        public void should_print_the_transactions()
        {
            List<Transaction> transactions = someTransactions();

            A.CallTo(() => transactionsRepo.AllTransactions()).Returns(transactions);

            account.PrintStatement();

            A.CallTo(() => printer.PrintTransactions(transactions)).MustHaveHappened();
        }

        private static List<Transaction> someTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction("10/11/2012", 100));
            transactions.Add(new Transaction("11/11/2012", 1000));
            transactions.Add(new Transaction("12/11/2012", -100));
            return transactions;
        }
    }
}
