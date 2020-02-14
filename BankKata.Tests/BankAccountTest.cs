using BankKata.Lib;
using NUnit.Framework;
using System;
using FakeItEasy;
using NUnit.Framework.Internal;

namespace BankKata.Tests
{
    public class BankAccountTest
    {
        private BankAccount account;
        private ITransactionsRepo transactionsRepo;

        [SetUp]
        public void Setup()
        {
            transactionsRepo = A.Fake<ITransactionsRepo>();
            account = new BankAccount(transactionsRepo);
                
        }

        [Test]
        public void should_store_transactions_in_a_repo() {

            account.Deposit(500);

            A.CallTo(()=>transactionsRepo.addDepositTransaction("14/02/2020",500)).MustHaveHappened();
        }
    }
}
