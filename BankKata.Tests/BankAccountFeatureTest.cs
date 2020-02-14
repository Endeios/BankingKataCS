using BankKata.Lib;
using FakeItEasy;
using NUnit.Framework;

namespace BankKata.Tests
{
    public class BankAccountFeatureTest
    {
        private BankAccount account;
        private IBankConsole console;
        private IBankClock clock;

        [SetUp]
        public void Setup()
        {
            console = A.Fake<IBankConsole>();
            clock = A.Fake<IBankClock>();

            account = new BankAccount(new TransactionsRepo(), clock);
        }

        [Test]
        [Ignore("I am focusing on the unit tests right now")]
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