using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Rectangle : AbstractShape
    {
        public override void Draw()
        {
            color.Bepaint("长方形");
        }
    }
}
