using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOopApp1
{
    internal class Driver : Person
    {
        public string LisenceNumber { get; set; }   
        public Driver(string firstName, string middleName, string lastName, string iName, string imidName, string lisenceNumber) : 
            base(firstName, middleName, lastName, iName, imidName)
        {
            LisenceNumber = lisenceNumber;
        }
        public override string GetInfo()
        {
            string info = GetShortName() + ", Права: " + LisenceNumber;
            return info;
        }
    }
}
