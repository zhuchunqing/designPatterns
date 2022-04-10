using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatterns
{
    internal class eggs: IFoods
    {

        public void GetFood()
        {
            Console.WriteLine("egg");
        }
    }
}
