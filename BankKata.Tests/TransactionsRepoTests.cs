using System;
using System.Collections.Generic;
using System.Text;
using BankKata.Lib;
using NUnit.Framework;

namespace BankKata.Tests
{
    class TransactionsRepoTests
    {
        private ITransactionsRepo transactionsRepo;

        [SetUp]
        public void Setup()
        {
            transactionsRepo = new TransactionsRepo();
        }


        [Test]
        public void should_store_deposit_transactions() 
        {
            transactionsRepo.AddDepositTransaction("20/10/2010", 100);

            var transactions = transactionsRepo.AllTransactions();
        }
    }
}
