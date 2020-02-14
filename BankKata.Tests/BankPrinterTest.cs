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

            A.CallTo(()=>bankConsole.PrintLine("Date || Amount || Balance")).MustHaveHappened();
        }
    }
}
