using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
namespace UnityIoCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer uc = new UnityContainer();
            uc.RegisterType<ICompany, Company>();
            Employee emp = uc.Resolve<Employee>();
            emp.DisplaySalary();
            Console.ReadKey();
        }
    }
}
