using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    internal interface IBuilder
    {
       void setUsbCount();
       void  setKeyboard();
       void setDisplay();
       Computer getComputer();
    }
}
