//Name: Daria Green
//Email: Dgreen50@cnm.edu
//File: InvestmentCalcTests.cs

using GreenInvestmentCalc;

namespace InvestmentCalcTests
{
    [TestClass]
    public sealed class InvestmentCalcTests
    {
        [TestMethod]
        public void Calc_ShouldReturnCorrectFutureValue()
        {
            // Arrange
            var investmentCalc = new InvestmentCalc
            {
                Principle = 1000,
                InterestRate = 5,
                CompoundsPerYear = 12,
                Years = 10
            };

            // Act
            investmentCalc.Calc();

            // Assert
            Assert.AreEqual(1647.01, investmentCalc.FutureValue, 0.01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetPrinciple_ShouldThrowExceptionForInvalidValue()
        {
            // Arrange
            var investmentCalc = new InvestmentCalc();

            // Act
            investmentCalc.Principle = -1;
        }

    }
}
