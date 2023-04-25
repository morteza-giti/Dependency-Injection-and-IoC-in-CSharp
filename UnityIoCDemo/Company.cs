using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIoCDemo
{
    public interface ICompany
    {
        void ShowSalary();
    }
    public class Company : ICompany
    {
        public void ShowSalary()
        {
            Console.WriteLine("Your salary is 40 K");
        }
    }
}
