using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class AbstractShape
    {
        public IColor color;
        public void SetColor(IColor color)
        {
            this.color= color;
        }
        public abstract void Draw();
    }
}
