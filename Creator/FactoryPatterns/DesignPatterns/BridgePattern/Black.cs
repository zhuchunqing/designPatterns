using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Black : IColor
    {
        public void Bepaint(string shape)
        {
            Console.WriteLine("黑色的" + shape);
        }
    }
}
