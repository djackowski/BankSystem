namespace BankSystem.Operations
{
    public class CloseOverdraft : IOperation
    {
        public BankAccount BankAccount { get; private set; }

        public CloseOverdraft(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }

        public void ExecuteOperation()
        {
            BankAccount.HasOverdraft = false;
        }
    }
}
