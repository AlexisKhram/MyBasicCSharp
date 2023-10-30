using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOopApp1
{
    public class Person
    {
        /*
        public string FirstName;
        public string MiddleName;
        public string LastName;
        */
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Iname { get; set; }
        public string ImidName { get; set; }
        public Person(string firstName, string middleName, string lastName, string iName, string imidName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Iname = iName;
            ImidName = imidName;
        }
        public Person(string firstName, string lastName, string iName)
        {
            FirstName = firstName;
            MiddleName = "";
            LastName = lastName;
            Iname = iName;
            ImidName = "";
        }
        public string GetFullName()
        { 
            string fullName = FirstName;
            if(MiddleName.Length > 0) fullName += " " + MiddleName;
            fullName += " " + LastName;    
            return fullName;
        }
        public string GetShortName()
        {
            string shortname = LastName + " " + Iname + ".";
            if(ImidName.Length > 0) shortname += ImidName + ".";
            return shortname; 
        }
        public virtual string GetInfo()
        {
            string info = GetShortName();
            return info;
        }
    }
}
