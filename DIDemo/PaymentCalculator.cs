using System;

namespace DIDemo
{
    public interface IPaymentCalculator
    {
        decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years);
    }
    public class PaymentCalculator: IPaymentCalculator
    {
        public decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years)
        {
            decimal total = Price * (1 + Years * 0.1M);
            decimal monthly = (total - Deposit) / (Years * 12);
            return System.Math.Round(monthly, 2, MidpointRounding.AwayFromZero);
        }
    }
    public class NewPaymentCalculator : IPaymentCalculator
    {
        public decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years)
        {
            decimal total = Price * (3 + Years * 0.2M);
            decimal monthly = (total - Deposit) / (Years * 10);
            return System.Math.Round(monthly, 2, MidpointRounding.AwayFromZero);
        }
    }
    public class EvenNewerPaymentCalculator : IPaymentCalculator
    {
        public decimal GetMonthlyPayment(decimal Price, decimal Deposit, int Years)
        {
            decimal total = Price * (2 + Years * 0.3M);
            decimal monthly = (total - Deposit) / (Years * 8);
            return System.Math.Round(monthly, 2, MidpointRounding.AwayFromZero);
        }
    }
}