using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    internal class A2Car : ICar
    {
        public void makeCar()
        {
            Console.WriteLine("A2");
        }
    }
    internal class A3Car : ICar
    {
        public void makeCar()
        {
            Console.WriteLine("A3");
        }
    }
    internal class A4Car : ICar
    {
        public void makeCar()
        {
            Console.WriteLine("A4");
        }
    }
}
