using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Adress
    {
        private string _street;
        private string _city;
        private string _zipCode;
        private Countries _country;

        public Adress()
        {

        }

        public Adress(string street, string city, string zipCode, Countries country)
        {
            _street = street;
            _city = city;
            _zipCode = zipCode;
            _country = country;
        }
    }
}
