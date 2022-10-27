using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5ABC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Customer customer;
        CustomerManager customerManager;
        public MainWindow()
        {
            customerManager = new CustomerManager();
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ContactWindow contactWindow = new ContactWindow();

            if(contactWindow.ShowDialog() == true)
            {
                Customer customer = contactWindow.Customer;
                customerManager.AddToList(customer);
                UpdateList();
            }
            else
            {
                MessageBox.Show("Customer was not added");
            }
        }

        private void UpdateList()
        {
            lstCustomers.Items.Clear();
            for(int i = 0;i<customerManager.Count; i++)
            {
                lstCustomers.Items.Add(customerManager.GetCustomerFromList(i).ToString());
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            customerManager.RemoveFromListAtIndex(lstCustomers.SelectedIndex);
            UpdateList();
            lstCustomerDetails.Items.Clear();
        }


        private void UpdateCustomerDetailsList()
        {
            int index = lstCustomers.SelectedIndex;
            Customer customer = customerManager.GetCustomerFromList(index);

            lstCustomerDetails.Items.Clear();
            lstCustomerDetails.Items.Add(customer.Contact.Name +" "+ customer.Contact.LastName);
            lstCustomerDetails.Items.Add(customer.Contact.Address.City);
            lstCustomerDetails.Items.Add(customer.Contact.Address.ZipCode + " " +customer.Contact.Address.Street);
            lstCustomerDetails.Items.Add(customer.Contact.Address.Country);
            lstCustomerDetails.Items.Add(string.Empty);
            lstCustomerDetails.Items.Add("Emails:");
            lstCustomerDetails.Items.Add("Private " + customer.Contact.Email.EmailPersonal);
            lstCustomerDetails.Items.Add("Office " +customer.Contact.Email.EmailWork);
            lstCustomerDetails.Items.Add(string.Empty);
            lstCustomerDetails.Items.Add("Phone Numbers:");
            lstCustomerDetails.Items.Add("Private " + customer.Contact.Phone.PhoneHome);
            lstCustomerDetails.Items.Add("Office " + customer.Contact.Phone.PhoneCell);

        }

        private void lstCustomers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = lstCustomers.SelectedIndex;
            if (index != -1)
            {
                UpdateCustomerDetailsList();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            // by creating object you are also passing the customer from the list in customer manager
            ContactWindow contactWindow = new ContactWindow(customerManager.GetCustomerFromList(lstCustomers.SelectedIndex));
            contactWindow.ShowDialog();
            if(contactWindow.DialogResult == true)
            {
                Customer customer = contactWindow.Customer; // GETTER from the contactwindow declaring the newly created object of customer.
                customerManager.EditCustomerInList(customer, lstCustomers.SelectedIndex); // we are passing the object from 

                UpdateList();
                lstCustomerDetails.Items.Clear();
            }
            else
            {
                MessageBox.Show("Customer was not modified");
            }
        }

        private void IsSelectedIndexOk()
        {

        }
    }
}
