package accounts;

import operations.BankingOperationFactory;

import java.util.Calendar;

public class CreditAccount extends Account{
    public CreditAccount(int id, Calendar createdDate, int balance, History history, BankingOperationFactory factory, RateOfInterest rateOfInterest) {
        super(id, createdDate, balance, history, factory, rateOfInterest);
    }
}
