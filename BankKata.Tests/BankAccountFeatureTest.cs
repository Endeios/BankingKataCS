using BankKata.Lib;
using NUnit.Framework;
using System;
using FakeItEasy;

namespace BankKata.Tests
{
    public class BankAccountFeatureTest
    {
        private BankAccount account;
        private IBankConsole console;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount();
            console = A.Fake<IBankConsole>();
        }

        [Test]
        public void print_statement_should_have_all_transactions()
        {
            account.Deposit(1500);
            account.Withdraw(500);
            account.Deposit(300);

            account.PrintStatement();

          
            assertHasBeenPrinted("Date || Amount || Balance");
            assertHasBeenPrinted("22 / 01 / 2016 || 300 || 1300");
            assertHasBeenPrinted("12 / 01 / 2016 || -500 || 1000");
            assertHasBeenPrinted("02 / 11 / 2015 || 1500 || 1500");
        }

        private void assertHasBeenPrinted(string line)
        {
            A.CallTo(() => console.PrintLine(line)).MustHaveHappened();
        }
    }
}