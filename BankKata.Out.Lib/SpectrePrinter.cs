using System.Collections.Generic;
using BankKata.Lib;
using Spectre.Console;
using System.Threading;
using System.Globalization;


namespace BankKata.Out.Lib
{
    public class SpectrePrinter:ITransactionPrinter
    {
        public void PrintTransactions(IList<Transaction> transactions)
        {
            var table = new Table();
            CultureInfo cz = new CultureInfo("cs-CZ");
            int running = 0;
            table.Border(TableBorder.Rounded);
            table.AddColumn(new TableColumn("📅 [bold yellow]Date[/]").Centered());
            table.AddColumn(new TableColumn("💵 [underline green]Amount[/]").Centered());
            table.AddColumn(new TableColumn("⚖ [pink1]Balance[/] ").Centered());

            foreach (Transaction transaction in transactions)
            {
                Interlocked.Add(ref running, transaction.Amount);
                table.AddRow(@$"{transaction.Date}",@$"{transaction.Amount.ToString("c",cz)}", @$"{running.ToString("c",cz)}");
            }
            AnsiConsole.Render(table);
        }
    }
}
