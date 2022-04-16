using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxypatterns
{
    public class Proxy
    {
        private RealSubject realSubject;
        public void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            preRequest();
            realSubject.Request();
            postRequest();
        }
        public void preRequest()
        {
            Console.WriteLine("访问真实主题之前的预处理。");
        }
        public void postRequest()
        {
            Console.WriteLine("访问真实主题之后的后续处理。");
        }
    }
}
