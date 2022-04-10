using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPatterns
{
    internal interface IFactory
    {
        IFoods footFactory();
    }
}
