using BankKata.Lib;
using NUnit.Framework;
using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankKata.Tests
{
    class BankPrinterTest
    {
        private BankPrinter bankPrinter;
        private IBankConsole bankConsole;

        [SetUp]
        public void Setup()
        {
            bankConsole = A.Fake<IBankConsole>();
            bankPrinter = new BankPrinter(bankConsole);
        }

        [Test]
        public void should_print_the_header_when_there_are_no_transactions()
        {
            IList<Transaction> emptyTransactions = new List<Transaction>();
            bankPrinter.PrintTransactions(emptyTransactions);

            A.CallTo(() => bankConsole.PrintLine("Date || Amount || Balance")).MustHaveHappened();
        }

        [Test]
        public void should_print_the_transactions_in_inverse_order()
        {
            IList<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction("10 / 04 / 2012", 100));
            transactions.Add(new Transaction("11 / 04 / 2012", 1000));
            bankPrinter.PrintTransactions(transactions);



            A.CallTo(() => bankConsole.PrintLine("Date || Amount || Balance")).MustHaveHappened()
                .Then(A.CallTo(() => bankConsole.PrintLine("11 / 04 / 2012 || 1000 || 1100")).MustHaveHappened())
                .Then(A.CallTo(() => bankConsole.PrintLine("10 / 04 / 2012 || 100 || 100")).MustHaveHappened());
        }
    }
}
