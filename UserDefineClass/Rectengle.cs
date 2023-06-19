using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineClass
{
    internal class Rectengle
    {
        public int Length;
        public int Width;
        public int Area()
        {
            return Length * Width;
        }
        public int perimeter()
        {
            return 2*(Length + Width);
        }
    }
}
