using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5ABC
{
    public class Phone
    {
        private string _phoneCell;
        private string _phoneHome;

        public Phone()
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


    }
}
