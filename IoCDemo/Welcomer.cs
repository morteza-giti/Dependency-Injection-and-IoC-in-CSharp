using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDemo
{
    public interface IWelcomer
    {
        void Welcome(string name);
    }
    public class Welcomer : IWelcomer
    {
        public void Welcome(string name)
        {
            Console.WriteLine("Welcome, dear " + name);
        }
    }
}
