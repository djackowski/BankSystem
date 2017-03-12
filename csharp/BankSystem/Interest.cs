using System;

namespace BankSystem
{
    public class Interest
    {
        public decimal Amount { get; private set; }
        public TimeSpan Period { get; private set; }

        public Interest(decimal amount, TimeSpan period)
        {
            Amount = amount;
            Period = period;
        }
    }
}
