namespace BankSystem.Operations
{
    public class DepositOperation : IOperation
    {
        public BankAccount BankAccount { get; private set; }
        public decimal Amount { get; private set; }

        public DepositOperation(BankAccount bankAccount, decimal amount)
        {
            BankAccount = bankAccount;
            Amount = amount;
        }

        public void ExecuteOperation()
        {
            BankAccount.Withdraw(Amount);
        }
    }
}
