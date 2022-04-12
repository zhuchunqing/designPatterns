using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Circle : AbstractShape
    {
        public override void Draw()
        {
            color.Bepaint("圆形");
        }
    }
}
