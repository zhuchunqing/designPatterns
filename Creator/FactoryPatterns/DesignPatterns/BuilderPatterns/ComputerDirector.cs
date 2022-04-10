using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    internal class ComputerDirector
    {
        public void makeComputer(IBuilder builder)
        {
            builder.setUsbCount();
            builder.setDisplay();
            builder.setKeyboard();
        }
    }
}
