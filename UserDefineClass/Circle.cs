using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineClass
{
    internal class Circle
    {
        public double radius;
        public double Area()
        {
            return Math.PI * Math.Pow(radius,2);
        }
        public double circumreference()
        {
            return 2 * Math.PI * radius;
        }



    }
}
