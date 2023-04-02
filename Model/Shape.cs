using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    // for overloading
    internal class Shape
    {
        public int Area(int length) 
        {

            return length;
        }
        public int Area(int lenth, int breadth, int height)
        {
            return lenth * breadth * height;
        }
        public double Area(double pie, int radius)
        {
            return pie * radius * radius;
        }
   }
}

