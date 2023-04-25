using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIoCContainer.Register<IMessenger>(new Messenger());
            MyIoCContainer.Register<IWelcomer>(new Welcomer());


            IMessenger messenger = MyIoCContainer.Resolve<IMessenger>();
            messenger.ShowMessage("Message from IoC");
            Console.WriteLine(".........................");
            IWelcomer welcomer = MyIoCContainer.Resolve<IWelcomer>();
            welcomer.Welcome("ProVid.ir");
            Console.WriteLine("..........................");
            Console.ReadKey();

        }
    }
}
