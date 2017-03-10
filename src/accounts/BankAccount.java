package accounts;

import operations.BankingOperationFactory;

import java.util.Calendar;

public class BankAccount extends Account {
    public BankAccount(int id, Calendar createdDate, int balance, RateOfInterest rateOfInterest,
                       BankingOperationFactory factory, History history) {
        super(id, createdDate, balance, history, factory, rateOfInterest);
    }

    @Override
    public void execute() {

    }
}
