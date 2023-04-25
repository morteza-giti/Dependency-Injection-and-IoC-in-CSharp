using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIoCDemo
{
    public interface IEmployee
    {
        void InjectCompnay(ICompany company);
    }
    public class Employee : IEmployee
    {
        private ICompany _Company;
        //[Dependency]
        //public ICompany Company
        //{
        //    get { return _Company; }
        //    set { _Company = value; }
        //}
        //[InjectionConstructor]
        //public Employee(ICompany company)
        //{
        //    _Company = company;
        //}
        public void DisplaySalary()
        {
            _Company.ShowSalary();
        }
        [InjectionMethod]
        public void InjectCompnay(ICompany company)
        {
            _Company = company;
        }
    }


}
