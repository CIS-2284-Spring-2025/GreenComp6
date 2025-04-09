//Name: Daria Green
//Email: Dgreen50@cnm.edu
//File: InvestmentCalc.cs

namespace GreenInvestmentCalc
{
    public class InvestmentCalc
    {
        private double principle;
        private double interestRate;
        private int compPerYear;
        private int years;

        public double Principle
        {
            get { return principle; }
            set
            {
                if (value <= 0 || value > double.MaxValue)
                    throw new ArgumentException("Principle must be between 0 and less than max double.");
                principle = value;
                Calc();
            }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Interest rate must be between 0 and 100.");
                interestRate = value;
                Calc();
            }
        }

        public int CompoundsPerYear
        {
            get { return compPerYear; }
            set
            {
                if (value < 1 || value > 24)
                    throw new ArgumentException("Compounds per year must be between 1 and 24.");
                compPerYear = value;
                Calc();
            }
        }
        public int Years
        {
            get { return years; }
            set
            {
                if (value < 1 || value > 30)
                    throw new ArgumentException("Years must be between 1 and 30.");
                years = value;
                Calc();
            }
        }

        public double FutureValue { get; private set; }

        public void Calc()
        {
            FutureValue = principle * Math.Pow(1 + (interestRate / 100) / compPerYear,
              compPerYear * years);
        }
    }
}
