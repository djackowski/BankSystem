namespace BankSystem.Operations
{
    public class CalculateInterestOperation : IOperation
    {
        public BankAccount BankAccount { get; private set; }

        public CalculateInterestOperation(BankAccount bankAccount)
        {
            BankAccount = bankAccount;
        }        

        public void ExecuteOperation()
        {           
            var accuredInterest = BankAccount.Balance * BankAccount.Interest.Amount;

            BankAccount.Deposit(accuredInterest);
        }
    }
}
