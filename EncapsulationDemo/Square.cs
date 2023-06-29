using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    internal class Square
    {
        //public int length;
       
        private int length;

        public void setlength(int l)
        {
            if(l < 0)
            {
                length = 0;
            }
            else
            {
                length= l;
            }
        }
        public int getLength() 
        { 
            return length; 
        }
        public int area()
        {
            return length * length;
        }
        public int parimeter()
        {
            return 4 * length;
        }
        
    }
}
