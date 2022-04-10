﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class Adapter:Target
    {
        private Adaptee adaptee=new Adaptee();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
