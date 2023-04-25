using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    public interface IDependency3
    {
        void SomeMethod2();
    }
    public class Dependency5 : IDependency3
    {
        public void SomeMethod2()
        {
            Console.WriteLine("Ctor Injection was called.");
        }
    }

    public class Dependent3
    {
        IDependency3 _dependency;

        public Dependent3(IDependency3 dependency)
        {
            _dependency = dependency;
        }
        public void CallDependency()
        {
            _dependency.SomeMethod2();
        }
    }

}
