using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class Bank
    {
        private string AtmPin = "pin1234";
        public string myAtmPin;


        public string getAtmPin()
        {
            myAtmPin = AtmPin;
            return myAtmPin;
        }

        
        public string setAtmPin(string newAtmPin)
        {
            AtmPin = newAtmPin;
            return AtmPin;
        }
    }
}
