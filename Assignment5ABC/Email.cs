using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Email
    {
        private string _emailPersonal;
        private string _emailWork;

        public Email()
        {

        }
        public Email(string emailPersonal) : this(emailPersonal, string.Empty)
        {

        }
        public Email(string emailPersonal,string emailWork)
        {
            _emailPersonal = emailPersonal;
            _emailWork = emailWork;
        }
    }
}
