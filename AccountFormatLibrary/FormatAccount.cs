using System;

namespace AccountFormatLibrary {

    public class FormatAccount {
        public static decimal CalculateInterestByMonth(int months, decimal interestRate, decimal Balance) {
            if(Balance < 0) {
                throw new ArgumentException("Balance Cannot be Negative.");
            }
            return Balance * (interestRate / 12) * months;
        }
    }
}
