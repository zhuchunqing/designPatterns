using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPatterns
{
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("接收者的action()方法被调用..");
        }
    }
}
