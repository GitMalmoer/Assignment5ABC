using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment5ABC
{
    public class Customer
    {
        private Contact _contact;
        private int _id;

        public Customer()
        {
            _contact = new Contact();
        }
        public Customer(Phone phone,Email email, Address address)
        {
            _contact =  new Contact(phone,email,address);
        }
        public Contact Contact
        {
            get { return _contact; }
            set { _contact = value; }
        }
        public int Id 
        { 
            set { _id = value; } 
            get { return _id; } 
        }

        public override string ToString()
        {
            string toString = string.Format("{0} {1}",_id,_contact.ToString());
            return toString;
        }

    }
}
