using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    internal class LenovoBuilder : IBuilder
    {

        private Computer computer;
        public LenovoBuilder(String cpu, String ram)
        {
            computer = new Computer(cpu, ram);
        }
        public Computer getComputer()
        {

            return computer;
        }

        public void setDisplay()
        {
            computer.setUsbCount(4);
        }

        public void setKeyboard()
        {
            computer.setKeyboard("联想键盘");
        }

        public void setUsbCount()
        {
            computer.setDisplay("联想显示器");
        }
    }
}
