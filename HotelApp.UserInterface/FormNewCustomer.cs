using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule;

namespace HotelApp.UserInterface
{
    public partial class FormNewCustomer : Form
    {
        public FormNewCustomer()
        {
            InitializeComponent();
        }

        private void btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            var customer = new CustomerAction();
            if (customer.NewCustomer(txt_FirstName.Text, txt_LastName.Text, txt_Address.Text,
                txt_City.Text, txt_Country.Text, txt_Email.Text, txt_PostalCode.Text))
            {
                MessageBox.Show("Customer added");
                Close();
            }
            else
            {
                MessageBox.Show("A customer needs a first- & lastname and an email");
            }
        }
    }
}
