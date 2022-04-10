using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatterns
{
    internal class pottoes : IFoods
    {
        public void GetFood()
        {
            Console.WriteLine("pottoes");
        }
    }
}
