package accounts;

import operations.BankingOperationFactory;

import java.util.Calendar;

public class DepositAccount extends Account {
    public DepositAccount(int id, Calendar createdDate, int balance, History history, BankingOperationFactory factory, RateOfInterest rateOfInterest) {
        super(id, createdDate, balance, history, factory, rateOfInterest);
    }
}
