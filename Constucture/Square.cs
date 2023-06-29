using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constucture
{
    internal class Square
    {
        public int length { get; set; }
        public int area()
        {
           return length* length;
        }
        public int parimeter()
        {
            return 4 * length;
        }
        public Square()
        {
            length = 0;
            Console.WriteLine("print constructure");
        }
        public Square(int l)
        {
            length = l;
            Console.WriteLine("print parameteries constructure");
        }
    }
}
