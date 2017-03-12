using System;

namespace BankSystem
{
    public class BankAccount
    {
        private bool _hasOverdraft;

        public int Id { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public Interest Interest { get; private set; }

        public bool HasOverdraft
        {
            get
            {
                return _hasOverdraft;;
            }
            set
            {
                if (_hasOverdraft != value && !IsOverdraft())
                {
                    _hasOverdraft = value;
                }
            }
        }

        public BankAccount(int id, int accountNumber, Interest interest)
        {
            Id = id;
            AccountNumber = accountNumber;
            Interest = interest;

            HasOverdraft = false;
            CreatedDate = DateTime.UtcNow;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance - amount > 0 || HasOverdraft)
            {
                Balance -= amount;
            }
        }

        private bool IsOverdraft()
        {
            return Balance < 0;
        }
    }
}
