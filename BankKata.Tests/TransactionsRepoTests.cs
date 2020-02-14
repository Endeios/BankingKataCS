using System;
using System.Collections.Generic;
using System.Text;
using BankKata.Lib;
using NUnit.Framework;

namespace BankKata.Tests
{
    class TransactionsRepoTests
    {
        private const string DATE = "20/10/2010";
        private ITransactionsRepo transactionsRepo;

        [SetUp]
        public void Setup()
        {
            transactionsRepo = new TransactionsRepo();
        }


        [Test]
        public void should_store_deposit_transactions() 
        {
            transactionsRepo.AddDepositTransaction(DATE, 100);

            var transactions = transactionsRepo.AllTransactions();

            Assert.That(transactions.Count == 1);
            Assert.That(transactions[0] == new Transaction(DATE, 100));
        }
    }
}
