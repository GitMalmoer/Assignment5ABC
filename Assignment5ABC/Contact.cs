using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment5ABC
{
    public class Contact
    {
        private string _name;
        private string _lastName;
        private string _fullName;


        private Phone _phone;
        private Email _email;
        private Address _address;

        public Contact()
        {
            _phone = new Phone();
            _email = new Email();
            _address = new Address();
        }
        public Contact(Phone phone,Email email,Address address ) 
        {
            _phone = phone;
            _email = email;
            _address = address;
        }
        public Contact(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public Phone Phone
        {
            get { return _phone; }
            set { _phone = value;}
        }
        public Email Email
        {
            get { return _email; }
            set { _email = value;}
        }
        public Address Address
        {
            get { return _address; }
            set { _address = value;}
        }

        private string FullName
        {
            get { return (_fullName = _lastName.ToUpper() +", " + _name);}
        }



        public override string ToString()
        {
            string toString = string.Format("{0} {1} {2}",FullName,_phone.ToString(),_email.ToString());
            return toString;
        }
    }
}
