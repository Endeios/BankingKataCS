using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

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
            int running = 0;

            List<string> rows = new List<string>();
            foreach (Transaction transaction in transactions)
            {
                Interlocked.Add(ref running, transaction.Amount);
                rows.Add(@$"{transaction.Date} || {transaction.Amount} || {running}");
            }

            rows.Reverse();
            foreach (String row in rows)
            {
                bankConsole.PrintLine(row);
            }

        }
    }
}
