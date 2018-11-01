using System;
using System.Collections.Generic;
using System.Linq;

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

        public List<Room> GetAvailableRooms(DateTime from, DateTime to, int persons)
        {
            using (var db = new HotelEntities())
            {
                return db.Rooms.Where
                (r => (r.Beds + r.ExtraBeds) >= persons &&
                (r.BookedFrom == null && r.BookedTo == null) ||
                (r.BookedFrom < from.Date && r.BookedTo < to.Date)).ToList();
            }
        }
    }
}
