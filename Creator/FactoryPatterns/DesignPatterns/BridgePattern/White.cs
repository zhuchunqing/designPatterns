using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class White : IColor
    {
        public void Bepaint(string shape)
        {
            Console.WriteLine("白色的" + shape);
        }
    }
}
