namespace BankSystem.Operations
{
    public class WithdrawOperation : IOperation
    {
        public BankAccount BankAccount { get; private set; }
        public decimal Amount { get; private set; }

        public WithdrawOperation(BankAccount bankAccount, decimal amount)
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