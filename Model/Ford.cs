using Daythree.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Ford : ICar, ICarRenew
    {
        /*  public string getBatterycharge()
          {
              return "car charge";
          }

          public string getCarMovement()
          {
              return "car move";
          }
          */
        public string getBatterycharge()
        {
            return "battery charged";
        }

        public string getCarMovement()
        { return " Car Moved";
        }

        public string getCarRenew()
        {
            return "Car Renews";
        }
    }
}
