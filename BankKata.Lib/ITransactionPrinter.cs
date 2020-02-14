using System.Collections.Generic;

namespace BankKata.Lib
{
    public interface ITransactionPrinter
    {
        void PrintTransactions(IList<Transaction> transactions);
    }
}