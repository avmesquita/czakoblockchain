using System;
using System.Collections.Generic;
using System.Text;

namespace CzakoZoltanBlockchain
{
    /// <summary>
    /// https://towardsdatascience.com/blockchain-explained-using-c-implementation-fb60f29b9f07
    /// </summary>
    public class Transaction
    {
        public string From { get; }
        public string To { get; }
        public double Amount { get; }
        public Transaction(string from, string to, double amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }
    }
}
