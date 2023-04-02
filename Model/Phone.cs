using Daythree.Interfaace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Phone
    {
        // virtual method is usedannote override
        
        public virtual string PhoneNumber { get; set; }
        public virtual string shutdown()
        {
            return "shutdown";

        }
       /* public override string shutdownandroid()
        {
            return "android shutdown ";
        }*/
       public string Iphone()
        {
            return " Hello iphone user";
        }

    }
}
