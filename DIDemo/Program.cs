using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependent dp = new Dependent();
            //dp.InjectDependency(new Dependency());
            //dp.CallDependency();
            //dp.InjectDependency(new Dependency2());
            //dp.CallDependency();

            //PaymentTerms pt = new PaymentTerms();
            //pt.Price = 100;
            //pt.Years = 4;
            //pt.Deposit = 30;
            //pt.InjectCalculator(new PaymentCalculator());
            //Console.WriteLine(pt.GetMonthlyPayment());
            //pt.InjectCalculator(new NewPaymentCalculator());
            //Console.WriteLine(pt.GetMonthlyPayment());
            //pt.InjectCalculator(new EvenNewerPaymentCalculator());
            //Console.WriteLine(pt.GetMonthlyPayment());

            //Dependent2 dp2 = new Dependent2();
            //dp2.Dependency = new Dependency4();
            //dp2.CallDependency();


            //PaymentTerms pt = new PaymentTerms();
            //pt.Price = 100;
            //pt.Years = 4;
            //pt.Deposit = 30;
            //pt.Calcualtor=new PaymentCalculator();
            //Console.WriteLine(pt.GetMonthlyPayment());
            //pt.Calcualtor = new NewPaymentCalculator();
            //Console.WriteLine(pt.GetMonthlyPayment());
            //pt.Calcualtor = new EvenNewerPaymentCalculator();
            //Console.WriteLine(pt.GetMonthlyPayment());

            //Dependent3 dp = new Dependent3(new Dependency5());
            //dp.CallDependency();

            PaymentTerms pt = new PaymentTerms(new PaymentCalculator());
            Console.WriteLine(pt.GetMonthlyPayment()); 
            Console.ReadKey();
        }
    }
}
