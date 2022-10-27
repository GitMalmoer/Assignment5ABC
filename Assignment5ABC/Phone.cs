using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment5ABC
{
    public class Phone
    {
        private string _phoneCell;
        private string _phoneHome;

        public Phone() : this(string.Empty, string.Empty)
        {
        }
        public Phone(string phoneCell) : this(phoneCell,string.Empty)
        {
        }
        public Phone(string phoneCell, string phoneHome)
        {
            _phoneCell = phoneCell;
            _phoneHome = phoneHome;
        }

        public string PhoneCell
        {
            get { return _phoneCell; }
            set { _phoneCell = value; }
        }

        public string PhoneHome
            {
            get { return _phoneHome; }
                
            set {_phoneHome = value;}
        }

        public override string ToString()
        {
            string toString = string.Format("{0}",_phoneCell);
            return toString;
        }


    }
}
