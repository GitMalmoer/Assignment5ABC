using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _zipCode;
        private Countries _country;

        public Address()
        {

        }

        public Address(string street, string city, string zipCode, Countries country)
        {
            _street = street;
            _city = city;
            _zipCode = zipCode;
            _country = country;
        }

        public string Street
            { get { return _street; } set { _street = value; } }

        public string City
            { get { return _city; } set { _city = value; } }

        public string ZipCode
            { get { return _zipCode; } set { _zipCode = value; } }

        public Countries Country
        {
            get 
            { return _country; } 
            set 
            { _country = value; } 
        }

        public string CountryString
        {
            get { return CountryToString(); }
        }

        public string CountryToString()
        {
            string countryString = _country.ToString();
            if(_country.ToString().Contains('_'))
            {
                countryString = _country.ToString().Replace('_', ' ');
                return countryString;
            }
            else
            {
                return countryString;
            }
        }



    }
}
