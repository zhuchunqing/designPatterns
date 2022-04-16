using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    internal class ComputerDirector
    {
        IBuilder builder;
        public ComputerDirector(IBuilder builder) 
        {
            this.builder = builder;
        }
        public void makeComputer(IBuilder builder)
        {
            builder.setUsbCount();
            builder.setDisplay();
            builder.setKeyboard();
        }
    }
}
