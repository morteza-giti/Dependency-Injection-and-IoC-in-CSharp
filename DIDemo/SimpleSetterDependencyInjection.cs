using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    public interface IDependency2
    {
        void SomeMethod2();
    }
    public class Dependency4 : IDependency2
    {
        public void SomeMethod2()
        {
            Console.WriteLine("Setter Injection was called.");
        }
    }
  
    public class Dependent2
    {
        IDependency2 _dependency;

        public IDependency2 Dependency
        {
            set { _dependency = value; }
        }
        public void CallDependency()
        {
            _dependency.SomeMethod2();
        }
    }

}
