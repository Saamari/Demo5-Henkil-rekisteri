using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6_Henkilörekisteri
{

    /// <summary>
    /// This class contains Person properties.
    /// </summary>

    class Person
    {
        public string Firstname { get; set;}
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set;}

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
