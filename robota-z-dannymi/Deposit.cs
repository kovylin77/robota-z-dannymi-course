using System;

namespace robota_z_dannymi
{
    public class Deposit
    {
        private double Amount { get; }

        private const double Percentage = 0.02;

        public Deposit(int amount)
        {
            Amount = amount;
        }

        public double CalculateAmountAfterXMonths(int x)
        {
            double newAmount = Amount;
            for (var i = 0; i < x; i++)
            {
                newAmount += newAmount * Percentage;
            }
            return newAmount;
        }
    }
}