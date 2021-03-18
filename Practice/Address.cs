using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }



        /// <summary>
        /// Default CTOR
        /// </summary>
        public Address()
        {
            StreetNumber = 0;
            StreetName = string.Empty;
        }

        

    }
}
