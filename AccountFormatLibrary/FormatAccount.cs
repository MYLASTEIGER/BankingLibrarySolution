using System;

namespace AccountFormatLibrary {

    public class FormatAccount {
        public static decimal CalculateInterestByMonth(int months, decimal interestRate, decimal Balance) {
            return Balance * (interestRate / 12) * months;
        }
    }
}
