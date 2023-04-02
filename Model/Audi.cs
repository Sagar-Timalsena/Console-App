using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Audi : Car
    {
        //overriding abstract method from abstract class i.e Car
        public override string CarMovement()
        {
            return "Car Move fast";
        }
    }
}
