using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace HotelApp.DataModule.Repository
{
    public class RoomRepository
    {

        public Room GetRoom(int roomId)
        {
            using (var db = new HotelEntities())
            {
                return db.Rooms.SingleOrDefault(r => r.RoomId == roomId);
            }
        }

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut, int persons)
        {
            using (var db = new HotelEntities())
            {
                var rooms = db.Rooms.Where(r => r.Beds + r.ExtraBeds >= persons).ToList();
                var unavailable = db.GetUnavailableRooms(checkIn, checkOut).ToList();
                if (unavailable.Any())
                {
                    return rooms.Where(r => unavailable.All(b => b.RoomId != r.RoomId)).ToList();
                }
                return rooms;



                // WITHOUT STORED PROCEDURE //

                //var rooms = db.Rooms.Where(r => r.Beds + r.ExtraBeds >= persons).ToList();
                //var bookings = (from b in db.Bookings
                //                where
                //                    ((checkIn >= b.CheckIn) && (checkIn <= b.CheckOut)) ||
                //                    ((checkOut >= b.CheckIn) && (checkOut <= b.CheckOut)) ||
                //                    ((checkIn <= b.CheckIn) && (checkOut >= b.CheckIn) && (checkOut <= b.CheckOut)) ||
                //                    ((checkIn >= b.CheckIn) && (checkIn <= b.CheckOut) && (checkOut >= b.CheckOut)) ||
                //                    (checkIn <= b.CheckIn) && (checkOut >= b.CheckOut)
                //                select b.Room).ToList();


                //if (bookings.Count > 0)
                //{
                //    return rooms.Where(r => bookings.All(b => b.RoomId != r.RoomId)).ToList();
                //}
                //return rooms;
            }
        }
    }
}
