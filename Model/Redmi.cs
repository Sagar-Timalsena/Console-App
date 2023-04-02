using Daythree.Interfaace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    //multiple inheritance with interface
    internal class Redmi : IcellPhone, IAndroid
    {
        public string InstallApp(string appName)
        {
            return "App Installed Success! App Name= " + appName;
        }

        public string Ring(string phoneModel)
        {
            return "phone ring! phone model=" + phoneModel;
        }
    }
}
