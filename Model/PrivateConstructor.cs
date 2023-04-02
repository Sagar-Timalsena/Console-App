using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class PrivateConstructor
    {
        public static string Name { get; set; }
        public static string PhoneNumber { get; set; }

        //creating private constructor
        private PrivateConstructor()
        {


        }
        public static void getManagerDetails(string managerName, string managerNumber)
        {
            Name= managerName;
            PhoneNumber = managerNumber;

            Console.WriteLine("Manager Name = "+ Name);
            Console.WriteLine("Manager Name = " + PhoneNumber);
        }
    }
}
