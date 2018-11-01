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

        public FormUpdateBooking(int bookingId)
        {
            _bookingId = bookingId;
            var repo = new BookingRepository();
            _room = repo.GetBooking(_bookingId).Room;
            InitializeComponent();
            ShowInformation();
            GenerateComboBox();
        }

        private void ShowInformation()
        {
            var manager = new BookingAction();
            datePicker_From.Value = _room.BookedFrom.Value;
            datePicker_To.Value = _room.BookedTo.Value;
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

            for (int j = 1; j < (_room.ExtraBeds + 1); j++)
            {
                cb_ExtraBeds.Items.Add(j);
            }
            cb_ExtraBeds.SelectedIndex = 0;
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
    }
}
