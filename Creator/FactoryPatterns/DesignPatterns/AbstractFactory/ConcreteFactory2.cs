using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ConcreteFactory2 : AbstractFactoryAB
    {
        public AbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public AbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}
