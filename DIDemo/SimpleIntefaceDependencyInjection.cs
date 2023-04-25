using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    public interface IDependency
    {
        void SomeMethod();
    }
    public class Dependency : IDependency
    {
        public void SomeMethod()
        {
            Console.WriteLine("Some Method was called.");
        }
    }
    public class Dependency2 : IDependency
    {
        public void SomeMethod()
        {
            Console.WriteLine("Some Method2 was called.");
        }
    }
    public interface IDependent
    {
        void InjectDependency(IDependency dependency);
    }
    public class Dependent : IDependent
    {
        IDependency _dependency;

        public void InjectDependency(IDependency dependency)
        {
            _dependency = dependency;
        }
        public void CallDependency()
        {
            _dependency.SomeMethod();
        }
    }

}
