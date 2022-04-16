using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns
{
    public class Decorator
    {
        public IComponent component;
        public void SetComponent(IComponent component)
        {
            this.component = component;
        }
        public void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
