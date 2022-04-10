using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatterns
{
    internal class pottoesFactory : IFactory
    {
        public IFoods footFactory()
        {
            return new pottoes();
        }
    }
}
