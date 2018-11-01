using System;
using System.Collections.Generic;
using System.Linq;
using HotelApp.DataModule;
using HotelApp.DataModule.Repository;

namespace HotelApp.BusinessLayer
{
    public class BookingAction
    {
        private readonly RoomRepository _roomRepository = new RoomRepository();
        private readonly BookingRepository _bookingRepository = new BookingRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public List<Booking> GetValidatedBookings()
        {
            var bookings = _bookingRepository.GetBookings();
            foreach (var booking in bookings)
            {
                if((DateTime.Today - booking.DateBooked).Days > 10 && !booking.Invoice.IsPaid)
                {
                    booking.IsValid = false;
                    booking.Room.BookedFrom = null;
                    booking.Room.BookedTo = null;
                    _bookingRepository.UpdateBooking(booking);
                }
            }

            bookings = _bookingRepository.GetBookings();

            return bookings;
        }

        public void BookRoom(int roomId, DateTime from, DateTime to, int customerId)
        {
            var room = _roomRepository.GetRoom(roomId);
            room.BookedTo = to;
            room.BookedFrom = from;
            var customer = _customerRepository.GetCustomer(customerId);

            var invoice = new Invoice
            {
                CustomerId = customerId,
                Amount = CalculatePrice(from, to, roomId),
                IsPaid = false
            };
            var booking = new Booking
            {
                CustomerId = customerId,
                Customer = customer,
                DateBooked = DateTime.Now,
                RoomId = room.RoomId,
                Room = room,
                Invoice = invoice
            };
            _bookingRepository.AddBooking(booking);
        }

        public decimal CalculatePrice(DateTime from, DateTime to, int roomid)
        {
            var room = _roomRepository.GetRoom(roomid);
            var days = (to - from).Days;
            if (days == 0)
            {
                return room.PricePerNight;
            }
            return room.PricePerNight * days;
        }

        public bool PayBooking(int bookingId, decimal paid)
        {
            var booking = _bookingRepository.GetBooking(bookingId);

            if (booking.Invoice.Amount == paid && !booking.Invoice.IsPaid)
            {
                booking.Invoice.IsPaid = true;
                booking.IsValid = true;
                _bookingRepository.UpdateBooking(booking);
                return true;
            }
            return false;
        }

        public void DeleteBooking(int bookingId)
        {
            var booking = _bookingRepository.GetBooking(bookingId);
            booking.Room.BookedFrom = null;
            booking.Room.BookedTo = null;
            var repo = new BookingRepository();
            repo.Delete(booking);
        }
    }
}
