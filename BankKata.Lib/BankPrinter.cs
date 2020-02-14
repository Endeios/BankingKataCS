using System;
using System.Collections.Generic;
using System.Text;

namespace BankKata.Lib
{
    public class BankPrinter : ITransactionPrinter
    {
        private const string HEADER = "Date || Amount || Balance";
        private readonly IBankConsole bankConsole;

        public BankPrinter(IBankConsole bankConsole) {
            this.bankConsole = bankConsole;
        }
        
        public void PrintTransactions(IList<Transaction> transactions)
        {
            bankConsole.PrintLine(HEADER);
        }
    }
}
