using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatterns
{
    internal class Operation
    {
        private double numbera = 0;
        private double numberb = 0;
        public double NumberA 
        {
            get { return numbera; }
            set { numbera = value; }

        }
        public double NumberB { 
            get { return numberb; }
            set { numberb = value; }
        }
        public virtual double GetResult() 
        {
            double result = 0;
            return result;
        }
    }
}
