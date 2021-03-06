//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp.DataModule
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingId { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public System.DateTime DateBooked { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int InvoiceId { get; set; }
        public System.DateTime CheckIn { get; set; }
        public System.DateTime CheckOut { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual Room Room { get; set; }
    }
}
