using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constucture
{
    internal class Rectangle
    {
        public int length { get; set; }
        public int width { get; set; }

        public int area()
        {
            return length * width;
        }
        public int parimeter()
        {
            return 2* (length + width);
        }

        public Rectangle()
        {
            length = 0;
            width = 0;
            Console.WriteLine("print constructrue");
        }
        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
            Console.WriteLine("print parameteries constructrue");
        }
    }
}
