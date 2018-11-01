using System;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule.Repository;

namespace HotelApp.UserInterface
{
    public partial class FormInvoice : Form
    {
        private readonly int _bookingId;

        public FormInvoice(int bookingId)
        {
            _bookingId = bookingId;
            InitializeComponent();
            LoadBookingInformation();
        }

        private void LoadBookingInformation()
        {
            var repo = new BookingRepository();
            var booking = repo.GetBooking(_bookingId);
            txt_CustomerId.Text = booking.Customer.CustomerId.ToString();
            txt_Amount.Text = booking.Invoice.Amount.ToString("C0");
            txt_BookingId.Text = booking.BookingId.ToString();
        }

        private void btn_RegisterPayment_Click(object sender, EventArgs e)
        {
            var manager = new BookingAction();
            if (manager.PayBooking(_bookingId, decimal.Parse(txt_Paid.Text)))
            {
                MessageBox.Show("Invoice payment is registred");
                Close();
            }
        }
    }
}
