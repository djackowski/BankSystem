namespace BankSystem.Operations
{
    public class OpenOverdraft : IOperation
    {
        public BankAccount BankAccount { get; private set; }

        public OpenOverdraft(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }

        public void ExecuteOperation()
        {
            BankAccount.HasOverdraft = true;
        }
    }
}
