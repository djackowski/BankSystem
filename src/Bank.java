import accounts.*;
import operations.BankingOperationFactory;

import java.util.GregorianCalendar;

public class Bank {

    public static void main(String[] args) {
        Account bankAccount = new BankAccount(0, new GregorianCalendar(2017, 10, 10), 100, new RateOfInterest(),
                new BankingOperationFactory(), new History());

       /* Account depositAccount = new DepositAccount(0, new GregorianCalendar(2017, 10, 10), 100, new RateOfInterest(),
                new BankingOperationFactory(), new History());*/

    }
}
