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

        public Email(): this(String.Empty, string.Empty)
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

        public string EmailPersonal 
        { 
            get { return _emailPersonal; } 
            set { _emailPersonal = value; } 
        }
        public string EmailWork 
        { 
            get { return _emailWork; } 
            set { _emailWork = value; } 
        }

        public override string ToString()
        {
            string toString = string.Format("{0}", _emailWork);
            return toString;

        }
    }
}
