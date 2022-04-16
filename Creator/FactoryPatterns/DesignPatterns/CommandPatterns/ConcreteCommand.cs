using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns
{
    public class ConcreteCommand : ICommand
    {
        private Receiver receiver;
        public ConcreteCommand(Receiver receiver) 
        {
            this.receiver = receiver;
        }
        public void execute()
        {
            Console.WriteLine("ConcreteCommand 执行");
        }
    }
}
