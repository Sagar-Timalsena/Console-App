using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daythree.Model
{
    internal class CopyConstructor
    {
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        //parameterized Constructor
        public CopyConstructor(string employeeName, string employeeNumber)
        {
            this.EmployeeName = employeeName;
            this.EmployeeNumber = employeeNumber;
        }
        public CopyConstructor(CopyConstructor copyConstructor)
        {
            Console.WriteLine("Employee Name = " + copyConstructor.EmployeeName);
            Console.WriteLine("Employee Phone Number = " + copyConstructor.EmployeeNumber);
        }
    }
}
