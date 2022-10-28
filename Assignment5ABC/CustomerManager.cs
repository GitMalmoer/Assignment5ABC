using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Assignment5ABC
{
    public class CustomerManager
    {
        private int _id = 100;
        List<Customer> _customerList;
        public CustomerManager()
        {
            _customerList = new List<Customer>();
        }
        public int Count
        {
            get { return _customerList.Count; }
        }

        public void AddToList(Customer customer)
        {
            _id++;
            customer.Id = _id;
            _customerList.Add(customer);
        }

        public void RemoveFromListAtIndex(int index)
        {
            if (CheckIndex(index))
            {
                _customerList.RemoveAt(index);
            }
        }
        public Customer GetCustomerFromList(int index)
        {
            if (CheckIndex(index))
            {
                Customer customer = _customerList[index];
                return customer;
            }
            else
            {
                MessageBox.Show("Selection is invalid");
                return null;
            }
        }

        public void EditCustomerInList(Customer customer, int index)
        {
            if(CheckIndex(index) && customer != null)
            {
                _customerList[index] = customer;
            }
        }


        public bool CheckIndex(int index)
        {
            if(index >= 0 && index < Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
