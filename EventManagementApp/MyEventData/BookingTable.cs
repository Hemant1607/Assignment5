//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyEventData
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingTable
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
        public string BookingApproval { get; set; }
        public Nullable<System.DateTime> ApprovalDate { get; set; }
        public string VenueName { get; set; }
        public string Location { get; set; }
        public string VenueType { get; set; }
        public Nullable<int> Guests { get; set; }
        public string EventType { get; set; }
    }
}