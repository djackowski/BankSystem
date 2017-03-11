package accounts;

import operations.BankingOperationFactory;

import java.util.Calendar;

public abstract class Account {
    protected final int id;
    protected final Calendar createdDate;
    protected final int balance;
    protected final History history;
    protected final BankingOperationFactory factory;
    protected final RateOfInterest rateOfInterest;

    protected Account(int id, Calendar createdDate, int balance, History history, BankingOperationFactory factory, RateOfInterest rateOfInterest) {
        this.id = id;
        this.createdDate = createdDate;
        this.balance = balance;
        this.history = history;
        this.factory = factory;
        this.rateOfInterest = rateOfInterest;
    }

    public abstract void execute();
}
