namespace BankSystem.Operations
{
    public class TransferOperation : IOperation
    {
        public BankAccount SenderAccount { get; private set; }
        public BankAccount ReceiverAccount { get; private set; }
        public decimal Amount { get; private set; }

        public void ExecuteOperation()
        {
            SenderAccount.Withdraw(Amount);
            ReceiverAccount.Deposit(Amount);
        }
    }
}
