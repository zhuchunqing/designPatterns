using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns
{
    public class Invoker
    {
        private ICommand command;
        public Invoker(ICommand command)
        {
            this.command = command;
        }
        public void setCommand(ICommand command)
        {
            this.command = command;
        }
        public void call()
        {
            Console.WriteLine("调用者执行命令command...");
            command.execute();
        }
    }
}
