using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDemo
{
    public interface IMessenger
    {
        void ShowMessage(string message);
    }
    public class Messenger : IMessenger
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
