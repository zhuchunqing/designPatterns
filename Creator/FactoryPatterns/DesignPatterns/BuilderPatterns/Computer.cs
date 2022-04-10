using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatterns
{
    public class Computer
    {
        private String cpu;//必须
        private String ram;//必须
        private int usbCount;//可选
        private String keyboard;//可选
        private String display;//可选

        public Computer(String cpu, String ram)
        {
            this.cpu = cpu;
            this.ram = ram;
        }
        public void setUsbCount(int usbCount)
        {
            this.usbCount = usbCount;
        }
        public void setKeyboard(String keyboard)
        {
            this.keyboard = keyboard;
        }
        public void setDisplay(String display)
        {
            this.display = display;
        }
        public String toString()
        {
            return "Computer{" +
                    "cpu='" + cpu + '\'' +
                    ", ram='" + ram + '\'' +
                    ", usbCount=" + usbCount +
                    ", keyboard='" + keyboard + '\'' +
                    ", display='" + display + '\'' +
                    '}';
        }
    }
}
