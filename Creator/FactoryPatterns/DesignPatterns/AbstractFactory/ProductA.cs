using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ProductA : AbstractProductA
    {
        public void GetProductA()
        {
            Console.WriteLine("productA");
        }
    }
}
