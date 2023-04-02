using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Bird:Animal
    {
        //Inheriting animal from bird
        public void fly()
        {
            Console.WriteLine("Bird flies");
        }
    }
}
