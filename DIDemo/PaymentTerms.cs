using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    //public interface IPaymentTerms
    //{
    //    void InjectCalculator(IPaymentCalculator paymentCalculator);
    //}
    public class PaymentTerms//: IPaymentTerms
    {
        //IPaymentCalculator _calculator;
        IPaymentCalculator _calculator;
        //public IPaymentCalculator Calcualtor { set { _calculator = value; } }
        public decimal Price { get; set; }
        public decimal Deposit { get; set; }
        public int Years { get; set; }
        public PaymentTerms(IPaymentCalculator Calculator)
        {
            _calculator = Calculator;
        }
        public decimal GetMonthlyPayment()
        {
            return _calculator.GetMonthlyPayment(Price, Deposit, Years);
        }

        //public void InjectCalculator(IPaymentCalculator paymentCalculator)
        //{
        //    _calculator = paymentCalculator;
        //}
    }
}
