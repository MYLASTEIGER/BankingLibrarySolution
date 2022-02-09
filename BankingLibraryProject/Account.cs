using AccountFormatLibrary;
using System;

namespace BankingLibraryProject {

    public class Account {
        public int AccountNumber { get; set; } = 1;
        public string Description { get; set; } = "Interest Bearing Account";
        public decimal Balance { get; set; } = 100;
        public decimal InterestRate { get; set; } = .12m;

        public decimal CalculateInterest(int months) {
            decimal interestAmount = FormatAccount.CalculateInterestByMonth(months, InterestRate, Balance);
            Balance += interestAmount;
            return interestAmount;


        }
    }
}
