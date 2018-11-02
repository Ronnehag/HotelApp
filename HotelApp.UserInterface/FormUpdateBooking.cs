using System;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule;
using HotelApp.DataModule.Repository;

namespace HotelApp.UserInterface
{
    public partial class FormUpdateBooking : Form
    {
        private readonly int _bookingId;
        private readonly Room _room;
        private readonly Booking _Booking;

        public FormUpdateBooking(int bookingId)
        {
            _bookingId = bookingId;
            var repo = new BookingRepository();
            _room = repo.GetBooking(_bookingId).Room;
            _Booking = repo.GetBooking(bookingId);
            InitializeComponent();
            ShowInformation();
            GenerateComboBox();
        }

        private void ShowInformation()
        {
            datePicker_From.Value = _Booking.CheckIn;
            datePicker_To.Value = _Booking.CheckOut;
            txt_PerNight.Text = _room.PricePerNight.ToString("C0");
            txt_Beds.Text = _room.Beds.ToString();
            UpdateInformation();
        }

        private void UpdateInformation()
        {
            var manager = new BookingAction();
            txt_RoomPrice.Text = manager.CalculatePrice(datePicker_From.Value, datePicker_To.Value, _room.RoomId).ToString("C0");
        }

        private void GenerateComboBox()
        {
            for (int i = 1; i < (_room.Beds + _room.ExtraBeds) + 1; i++)
            {
                cb_Customers.Items.Add(i);
            }
            if (_room.ExtraBeds != 0)
            {
                for (int j = 1; j < (_room.ExtraBeds + 1); j++)
                {
                    cb_ExtraBeds.Items.Add(j);
                }
                cb_ExtraBeds.SelectedIndex = 0;
            }
            cb_Customers.SelectedIndex = 0;
        }

        private void datePicker_To_ValueChanged(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void datePicker_From_ValueChanged(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var action = new BookingAction();
            if (action.UpdateBooking(_bookingId, datePicker_From.Value, datePicker_To.Value))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Invalid dates, it's already booked");
            }
        }
    }
}
