﻿using System;
using System.Collections.Generic;
using HotelApp.DataModule;
using HotelApp.DataModule.Repository;

namespace HotelApp.BusinessLayer
{
    public class BookingAction
    {
        private readonly RoomRepository _roomRepository = new RoomRepository();
        private readonly BookingRepository _bookingRepository = new BookingRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public List<Booking> ReturnValidBookings()
        {
            var bookings = _bookingRepository.GetBookings();
            foreach (var booking in bookings)
            {
                if (booking.IsValid == true) continue;
                if ((DateTime.Today - booking.DateBooked).Days > 10 && !booking.Invoice.IsPaid)
                {
                    booking.IsValid = false;
                    _bookingRepository.UpdateBooking(booking);
                }
            }

            return _bookingRepository.GetBookings();
        }

        public void BookRoom(int roomId, DateTime from, DateTime to, int customerId)
        {
            var room = _roomRepository.GetRoom(roomId);
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
                CheckIn = from,
                CheckOut = to,
                Invoice = invoice
            };
            _bookingRepository.AddBooking(booking);
        }


        public bool UpdateBooking(int bookingId, DateTime selectedFrom, DateTime selectedTo)
        {
            var customerBooking = _bookingRepository.GetBooking(bookingId);
            var bookedRoom = customerBooking.Room;
            var invoice = customerBooking.Invoice;

            var bookings = _bookingRepository.GetBookings();
            foreach (var booking in bookings)
            {
                if (booking.RoomId != bookedRoom.RoomId) continue;

                if (booking.CheckIn >= selectedFrom || booking.CheckOut <= selectedTo)
                {
                    SetAndUpdateBooking(invoice, selectedTo, selectedFrom, customerBooking);
                    return true;
                }
            }
            return false;

        }

        private void SetAndUpdateBooking(Invoice invoice, DateTime selectedToo, DateTime selectedFrom,
            Booking customerBooking)
        {
            customerBooking.CheckOut = selectedToo;
            customerBooking.CheckIn = selectedFrom;
            invoice.Amount = CalculatePrice(selectedFrom, selectedToo, customerBooking.RoomId);
            _bookingRepository.UpdateBooking(customerBooking);
        }

        public decimal CalculatePrice(DateTime fromDate, DateTime toDate, int roomid)
        {
            var room = _roomRepository.GetRoom(roomid);
            var timeSpan = (toDate.Date - fromDate.Date);
            var days = (int)timeSpan.TotalDays;

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
    }
}
