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
using System.Windows.Shapes;

namespace Assignment5ABC
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        Customer customer;
        public ContactWindow()
        {
            InitializeComponent();
            InitializeGui();
        }
        public ContactWindow(Customer customer) 
        {
            this.customer = customer;
            InitializeComponent();
            InitializeGui();

        }

        private void InitializeGui()
        {
            if(customer != null)
            {
                txtFirstName.Text = customer.Contact.Name.ToString();
                txtLastName.Text = customer.Contact.LastName.ToString();
                txtPhoneCell.Text = customer.Contact.Phone.PhoneCell.ToString();
                txtPhoneHome.Text = customer.Contact.Phone.PhoneHome.ToString();
                txtEmailPersonal.Text = customer.Contact.Email.EmailPersonal.ToString();
                txtEmailWork.Text = customer.Contact.Email.EmailWork.ToString();
                txtCity.Text = customer.Contact.Address.City.ToString();
                txtStreet.Text = customer.Contact.Address.Street.ToString();
                txtZipCode.Text = customer.Contact.Address.ZipCode.ToString();
                cmbCountry.SelectedItem = customer.Contact.Address.Country;
            }

            cmbCountry.ItemsSource = Enum.GetValues(typeof(Countries));
            cmbCountry.SelectedIndex = (int)Countries.Sverige;
        }

        public Customer Customer
        {
            get { return customer;}
            set { customer = value;} // SETTER IS USED FOR MODIFYING 
        }

        private void btnClickOk(object sender, RoutedEventArgs e)
        {

            // VERY IMPORTANT IF THEY CHECK IF CUSTOMER IS BEING MODIFIED OR IS IT BEING CREATED
            if (customer == null)
            {
                customer = new Customer();
                if (ValidateUserInput(ref customer))
                {
                    MessageBox.Show("Added sucesfully");
                    this.DialogResult = true;
                }
            }
            else 
            {
                if (ValidateUserInput(ref customer))
                {
                    MessageBox.Show("Edited sucesfully");
                    this.DialogResult = true;
                }
            }
            

        }

        private void btnClickCancel(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private bool ValidateUserInput(ref Customer customer)
        {
            if (ValidateNames(ref customer) && validatePhone(ref customer) && validateEmail(ref customer) && validateAddress(ref customer))
            {
                return true;
            }
            else
                return false;
        }
        private bool ValidateNames(ref Customer customer)
        {
            if (!string.IsNullOrEmpty(txtFirstName.Text) && !string.IsNullOrEmpty(txtLastName.Text))
            {
                customer.Contact.Name = txtFirstName.Text;
                customer.Contact.LastName = txtLastName.Text;
                return true;
            }
            else
            {
                MessageBox.Show("You need to write Name and last Name");
                return false;
            }
        }

        
        private bool validatePhone(ref Customer customer)
        {
            if(!string.IsNullOrEmpty(txtPhoneCell.Text))
            {
                customer.Contact.Phone = ReadPhone();
                return true;
            }
            else
            {
                MessageBox.Show("Cell phone is empty!");
                return false;
            }
        }

        private bool validateEmail(ref Customer customer)
        {
            if (!string.IsNullOrEmpty(txtEmailPersonal.Text))
            {
                customer.Contact.Email = ReadEmail();
                return true;
            }
            else
            {
                MessageBox.Show("Personal Email is empty!");
                return false;
            }
        }

        private bool validateAddress(ref Customer customer)
        {
            if (!string.IsNullOrEmpty(txtCity.Text))
            {
                customer.Contact.Address = ReadAddress();
                return true;
            }
            else
            {
                MessageBox.Show("City is empty!");
                return false;
            }
        }



        private Phone ReadPhone()
        {
            Phone phone = new Phone();
            phone.PhoneCell = txtPhoneCell.Text;
            phone.PhoneHome = txtPhoneHome.Text;
            
            return phone;
        }

        private Email ReadEmail()
        {
            Email email = new Email();
            email.EmailPersonal = txtEmailPersonal.Text;
            email.EmailWork = txtEmailWork.Text;
            return email;
        }

        private Address ReadAddress()
        {
            Address address = new Address();
            address.Street = txtStreet.Text;
            address.City = txtCity.Text;
            address.ZipCode = txtZipCode.Text;
            address.Country = (Countries)cmbCountry.SelectedItem;

            return address;
        }
    }
}
