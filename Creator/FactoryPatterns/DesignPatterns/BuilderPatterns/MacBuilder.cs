using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    internal class MacBuilder : IBuilder
    {
        private Computer computer;
        public MacBuilder(String cpu, String ram) 
        {
            computer = new Computer(cpu, ram);
        }
        public Computer getComputer()
        {
            
            return computer;
        }

        public void setDisplay()
        {
            computer.setUsbCount(2);
        }

        public void setKeyboard()
        {
            computer.setKeyboard("苹果键盘");
        }

        public void setUsbCount()
        {
            computer.setDisplay("苹果显示器");
        }
    }
}
