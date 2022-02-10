using AccountFormatLibrary;
using System;
using Xunit;

namespace TestInterestCalculation {
    public class UnitTest1 {

        [Theory]
        [InlineData(36, 36, 0.12, 100)]
        public void TestCalcIntByMonth(decimal interestAmount, int months, decimal interestRate, decimal balance)        {
            Assert.Equal(interestAmount,
                FormatAccount.CalculateInterestByMonth(months, interestRate, balance));
        }
        [Fact]
        public void TestNegativeBalance() {
            Action MakeBalanceNegative = () => FormatAccount.CalculateInterestByMonth(1, .01m, -100);
            Assert.Throws<ArgumentException>(MakeBalanceNegative);
        }
    }
}
