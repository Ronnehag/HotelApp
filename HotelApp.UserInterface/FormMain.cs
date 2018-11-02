using System;
using System.Linq;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule;

namespace HotelApp.UserInterface
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            new FormNewCustomer().Show();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadListBox();
        }

        private void ShowCustomerDescription()
        {
            if (listBox_RegistredCustomers.SelectedIndex == -1) return;
            var customer = (Customer)listBox_RegistredCustomers.SelectedItem;
            txt_FirstName.Text = customer.FirstName;
            txt_LastName.Text = customer.LastName;
            txt_Address.Text = customer.Address;
            txt_City.Text = customer.City;
            txt_Country.Text = customer.Country;
            txt_Email.Text = customer.Email;
        }

        private void ClearText()
        {
            txt_FirstName.Text = string.Empty;
            txt_LastName.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_City.Text = string.Empty;
            txt_Country.Text = string.Empty;
            txt_Email.Text = string.Empty;
        }

        private void LoadListBox()
        {
            var repo = new CustomerRepository();
            var customers = repo.GetCustomers().ToList();
            listBox_RegistredCustomers.DisplayMember = "FullName";
            listBox_RegistredCustomers.ValueMember = "CustomerId";
            listBox_RegistredCustomers.DataSource = customers;

        }

        private void listBox_RegistredCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCustomerDescription();
        }

        private void btn_ManageBookings_Click(object sender, EventArgs e)
        {
            new FormBookingManager().Show();
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            if (listBox_RegistredCustomers.SelectedIndex == -1)
            {
                MessageBox.Show("You need to select a customer");
                return;
            }
            var customer = (Customer)listBox_RegistredCustomers.SelectedItem;
            new FormNewBooking(customer).Show();
        }

        private void btn_DeleteSelectedCustomer_Click(object sender, EventArgs e)
        {
            if (listBox_RegistredCustomers.SelectedIndex == -1) return;
            var id = int.Parse(listBox_RegistredCustomers.SelectedValue.ToString());
            var manager = new CustomerAction();
            if (manager.DeleteCustomer(id))
            {
                MessageBox.Show("Customer deleted");
                LoadListBox();
                ClearText();

            }
            else
            {
                MessageBox.Show("You can't delete a customer with active bookings");
            }

        }

        private void btn_UpdateSelectedCustomer_Click(object sender, EventArgs e)
        {
            if (listBox_RegistredCustomers.SelectedIndex == -1) return;
            var id = int.Parse(listBox_RegistredCustomers.SelectedValue.ToString());
            var manager = new CustomerAction();
            if (manager.UpdateCustomer(id, txt_FirstName.Text, txt_LastName.Text, txt_Address.Text,
                txt_City.Text, txt_Country.Text, txt_Email.Text))
            {
                MessageBox.Show("Customer updated");
                LoadListBox();
                
            }
            else
            {
                MessageBox.Show("A customer needs a first- & lastname and email.");
            }
        }
    }
}
