using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxypatterns
{
    public class RealSubject:ISubject
    {
        public void Request()
        {
            Console.WriteLine("访问真实主题方法...");
        }
    }
}
