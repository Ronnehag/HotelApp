using System;
using System.Linq;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule;
using HotelApp.DataModule.Repository;

namespace HotelApp.UserInterface
{
    public partial class FormBookingManager : Form
    {
        public FormBookingManager()
        {
            InitializeComponent();
            LoadBookings();
        }

        public void LoadBookings()
        {
            var manager = new BookingAction();
            var bookings = manager.GetValidatedBookings();
            var view = bookings.Select(b => new
            {
                BookingID = b.BookingId,
                Room = b.Room.RoomType,
                Paid = b.Invoice.IsPaid,
                Customer = b.Customer.FullName,
                BookedDate = b.DateBooked,
                From = b.Room.BookedFrom,
                To = b.Room.BookedTo
            });
            var source = new BindingSource {DataSource = view};
            dataGridView_Bookings.DataSource = source;
        }

        private void btn_RegisterInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridView_Bookings.SelectedRows.Count < 0) return;
            var bookingId = int.Parse(dataGridView_Bookings.SelectedCells[0].Value.ToString());
            new FormInvoice(bookingId).Show();
            LoadBookings();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Bookings.SelectedRows.Count < 0) return;
            var bookingId = int.Parse(dataGridView_Bookings.SelectedCells[0].Value.ToString());
            var manager = new BookingAction();
            manager.DeleteBooking(bookingId);
            MessageBox.Show("Booking deleted");
            LoadBookings();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView_Bookings.SelectedRows.Count < 0) return;
            var bookingId = int.Parse(dataGridView_Bookings.SelectedCells[0].Value.ToString());
            new FormUpdateBooking(bookingId).Show();
        }
    }
}
