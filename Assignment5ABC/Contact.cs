using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Contact
    {
        private string _name;
        private string _lastName;

        Phone phone = new Phone();
        Email email = new Email();
        Adress adress = new Adress();

        public Contact()
        {

        }
        public Contact(string name, string lastName)
        {
            _name = name;
            _lastName = lastName;
        }
    }
}
