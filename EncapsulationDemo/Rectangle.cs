using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    internal class Rectangle
    {
        private int length;
        private int width;


        public int Length1
        {
            get { return length; }
            set
            {
                if (length < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }

        public int Width1
        {
            set
            {
                if(width < 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
            get 
            { 
                return width; 
            }
        }

        //public void setlength(int l)
        //{
        //    if (l < 0)
        //    {
        //        length = 0;
        //    }
        //    else
        //    {
        //        length = l;
        //    }
           
        //}
        //public void setwidth(int w)
        //{
        //    if(w<0)
        //    {
        //        width = 0;
        //    }
        //    else
        //    {
        //        width=w;
        //    }
            
        //}
        //public int getLength() 
        //{ 
        //    return length; 
            
        //}
        //public int getWidth()
        //{
        //    return width;
        //}
        public int area()
        {
            return length * width;
        }
        public int primeter()
        {
            return 2*(length+width);
        }
    }
}
