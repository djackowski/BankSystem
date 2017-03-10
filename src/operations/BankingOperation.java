package operations;

import java.util.Calendar;
import java.util.Currency;

public class BankingOperation {
    private final int id;
    private final Calendar createdDate;
    private final String opis;

    public BankingOperation(int id, Calendar createdDate, String description) {
        this.id = id;
        this.createdDate = createdDate;
        this.opis = description;
    }
}
