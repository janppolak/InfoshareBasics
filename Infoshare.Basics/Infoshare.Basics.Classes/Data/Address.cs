using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoshare.Basics.Classes.Data
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }

        private int _streetNumber;

        public int StreetNumber
        {
            get { return _streetNumber; }
            set
            {
                if (value > 99)
                {
                    _streetNumber = 99;
                }
                else
                {
                    _streetNumber = value;
                }
            }
        }
    }
}
