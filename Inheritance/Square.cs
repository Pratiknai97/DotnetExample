using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Square
    {
        public int length { get; set; }

        public virtual int Area()
        {
           return length* length;
        }
        public virtual int Perimeter()
        {
            return 4*length;
        }
    }
}
