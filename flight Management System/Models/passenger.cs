//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightReservation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class passenger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public passenger()
        {
            this.Bookings = new HashSet<Booking>();
        }
    
        public Nullable<int> passengerId { get; set; }
        public Nullable<int> passengerAge { get; set; }
        public int PassengerCount { get; set; }
        public long passengerUIN { get; set; }
        public int Luguagge { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Registration Registration { get; set; }
    }
}
