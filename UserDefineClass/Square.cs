using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefineClass
{
    internal class Square
    {
        public int Length;//Data Member
        public int Area()// Method 
        {
            return Length * Length;
        }
        public int perimeter()
        {
            return 4* Length;
        }
    }
}
