using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class A
    {
        private int value { get; set; }

        public class B : A
        {
            public int Getvalue()
            {
                return value;
            }
        }
    }
    //public class C : A
    //{
    //    public int Getvalue()
    //    {
    //        return value;
    //    }
    //}
}
