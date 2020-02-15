using System;

namespace BankKata.Lib
{
    public class BankClock : IBankClock
    {
        public string GetCurrentDateAsString()
        {
            return DateTime.Now.ToString("dd / MM / yyyy");
        }
    }
}