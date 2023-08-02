using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Rectangle : Square
    {
        public int width { get; set; }

        //public int Area()
        //{
        //    return length* width;
        //}
        //public int Perimeter()
        //{
        //    return 2 * (length + width);
        //}
        public override int Area()//argument written type method name
        {
            return base.Area();
        }
        
    }
}
