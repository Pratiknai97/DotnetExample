using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample1
{
    internal class Rectangle : IShape
    {
        public int length { get; set; }
        public int width { get; set; }

        public string Draw()
        {
            return "Rectangle";
        }
    }
}
