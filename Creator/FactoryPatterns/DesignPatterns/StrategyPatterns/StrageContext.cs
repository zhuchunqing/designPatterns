using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatterns
{
    internal class StrageContext:ICar
    {
        public ICar _Car=null;
        public StrageContext(ICar Car) 
        {
            _Car = Car;
        }
        public void makeCar()
        {
            _Car.makeCar();
            Console.WriteLine("StrageContext");
        }
    }
}
