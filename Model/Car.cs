using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    //abstract base class
    abstract internal class Car
    {
        //we cannot give body to abstract method
        public abstract string CarMovement();

        // Not abstract method
        public string CarBatteryCharge()
        {
            return " Car charging";
        }
    }
}
