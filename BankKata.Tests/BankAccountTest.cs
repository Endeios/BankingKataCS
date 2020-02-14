using BankKata.Lib;
using NUnit.Framework;
using System;
using FakeItEasy;
using NUnit.Framework.Internal;

namespace BankKata.Tests
{
    public class BankAccountTest
    {
        private const string DATE = "14/02/2020";
        private BankAccount account;
        private ITransactionsRepo transactionsRepo;
        private IBankClock clock;

        [SetUp]
        public void Setup()
        {
            transactionsRepo = A.Fake<ITransactionsRepo>();
            clock = A.Fake<IBankClock>();
            account = new BankAccount(transactionsRepo, clock);
                
        }

        [Test]
        public void should_store_deposit_transactions_in_a_repo() {

            
            A.CallTo(()=>clock.GetCurrentDateAsString()).Returns(DATE);
            account.Deposit(500);

            A.CallTo(()=>transactionsRepo.AddDepositTransaction(DATE, 500)).MustHaveHappened();
        }

        [Test]
        public void should_store_withdrawl_transactions_in_a_repo()
        {


            A.CallTo(() => clock.GetCurrentDateAsString()).Returns(DATE);
            account.Withdraw(500);

            A.CallTo(() => transactionsRepo.AddWithdrawlTransaction(DATE, 500)).MustHaveHappened();
        }
    }
}
