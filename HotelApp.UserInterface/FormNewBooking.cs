using System;
using System.Windows.Forms;
using HotelApp.BusinessLayer;
using HotelApp.DataModule;
using HotelApp.DataModule.Repository;

namespace HotelApp.UserInterface
{
    public partial class FormNewBooking : Form
    {
        private Customer _customer;

        public FormNewBooking(Customer customer)
        {
            _customer = customer;
            InitializeComponent();
            cb_Customers.SelectedIndex = 0;
        }
        private void btn_GetMatchingRooms_Click(object sender, EventArgs e)
        {
            UpdateRoomList();
        }

        private void UpdateRoomList()
        {
            if (cb_Customers.SelectedIndex == -1) return;
            var repo = new RoomRepository();
            var persons = int.Parse(cb_Customers.SelectedItem.ToString());
            var rooms = repo.GetAvailableRooms(datePicker_From.Value, datePicker_To.Value, persons);
            var source = new BindingSource
            {
                DataSource = rooms
            };
            listBox_AvailableRooms.DisplayMember = "RoomType";
            listBox_AvailableRooms.ValueMember = "RoomId";
            listBox_AvailableRooms.DataSource = source;
        }

        private void listBox_AvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_AvailableRooms.SelectedIndex == -1) return;
            var room = (Room)listBox_AvailableRooms.SelectedItem;
            var manager = new BookingAction();
            txt_Beds.Text = room.Beds.ToString();
            txt_RoomPrice.Text = manager.CalculatePrice(datePicker_From.Value, datePicker_To.Value, room.RoomId).ToString("C0");
            txt_PerNight.Text = room.PricePerNight.ToString("C0");
            ComboBoxBeds(room);
        }

        private void ComboBoxBeds(Room room)
        {
            if (room.ExtraBeds == 0) return;
            cb_ExtraBeds.Items.Clear();
            for (int i = 1; i < room.ExtraBeds + 1; i++)
            {
                cb_ExtraBeds.Items.Add(i);
            }
            cb_ExtraBeds.SelectedIndex = 0;
        }

        private void btn_Book_Click(object sender, EventArgs e)
        {
            if (listBox_AvailableRooms.SelectedIndex == -1) return;
            var roomId = int.Parse(listBox_AvailableRooms.SelectedValue.ToString());
            var manager = new BookingAction();
            manager.BookRoom(roomId, datePicker_From.Value, datePicker_To.Value, _customer.CustomerId);
            MessageBox.Show("Room is booked");
            Close();
        }

        private void datePicker_To_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateRoomList();
        }

        private void datePicker_From_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
            UpdateRoomList();
        }


        private void UpdateTotalPrice()
        {
            if (listBox_AvailableRooms.SelectedIndex == -1) return;
            var roomId = int.Parse(listBox_AvailableRooms.SelectedValue.ToString());
            var manager = new BookingAction();
            txt_RoomPrice.Text = manager.CalculatePrice(datePicker_From.Value, datePicker_To.Value, roomId).ToString("C0");
        }
    }
}
