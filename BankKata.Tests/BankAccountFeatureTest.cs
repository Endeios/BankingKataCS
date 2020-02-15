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
        private ITransactionPrinter printer;

        [SetUp]
        public void Setup()
        {
            console = A.Fake<IBankConsole>();
            clock = A.Fake<IBankClock>();
            printer = new BankPrinter(console);
            account = new BankAccount(new TransactionsRepo(), clock, printer);
        }

        [Test]
        //[Ignore("I am focusing on the unit tests right now")]
        public void print_statement_should_have_all_transactions()
        {

            A.CallTo(()=> clock.GetCurrentDateAsString()).ReturnsNextFromSequence("02 / 11 / 2015", "12 / 01 / 2016", "22 / 01 / 2016");

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