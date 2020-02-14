using System;
using System.Diagnostics.CodeAnalysis;

namespace BankKata.Lib
{
    public class Transaction : IEquatable<Transaction>
    {
        public Transaction(string date, int amount)
        {
            this.Date = date;
            this.Amount = amount;
        }

        public string Date { get; set; }
        public int Amount { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Transaction);
        }

        public bool Equals([AllowNull] Transaction other)
        {
            return other != null &&
                   Date == other.Date &&
                   Amount == other.Amount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Date, Amount);
        }
    }
}