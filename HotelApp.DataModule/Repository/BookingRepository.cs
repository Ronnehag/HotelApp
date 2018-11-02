﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HotelApp.DataModule.Repository
{
    public class BookingRepository
    {
        public void AddBooking(Booking booking)
        {
            using (var db = new HotelEntities())
            {
                db.Entry(booking.Room).State = EntityState.Unchanged;
                db.Entry(booking.Customer).State = EntityState.Unchanged;
                db.Bookings.Add(booking);
                db.Invoices.Add(booking.Invoice);
                db.SaveChanges();
            }
        }

        public void Delete(int bookingId)
        {
            using (var db = new HotelEntities())
            {
                var booking = db.Bookings.Include("Room").Include("Invoice").SingleOrDefault(b => b.BookingId == bookingId);
                if (booking != null)
                {
                    db.Entry(booking.Invoice).State = EntityState.Deleted;
                    db.Bookings.Remove(booking);
                    db.SaveChanges();
                }
            }

        }

        public void UpdateBooking(Booking booking)
        {
            using (var db = new HotelEntities())
            {
                db.Entry(booking.Invoice).State = EntityState.Modified;
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<Booking> GetBookings()
        {
            using (var db = new HotelEntities())
            {
                return db.Bookings.Include("Customer").Include("Room").Include("Invoice")
                    .Where(b => b.IsValid == null || b.IsValid == true).ToList();
            }
        }

        public Booking GetBooking(int id)
        {
            using (var db = new HotelEntities())
            {
                return db.Bookings.Include("Customer").Include("Room").Include("Invoice")
                    .SingleOrDefault(b => b.BookingId == id);
            }
        }
    }
}
