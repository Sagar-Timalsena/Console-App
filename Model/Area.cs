using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Area
    {
        public decimal FindArea(decimal l, decimal b)
        {
            return  l * b;

        }
        //circle
        public double FindArea(double r)
        {
            return 3.14*r*r;
        }
    }
}
