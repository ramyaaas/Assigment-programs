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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlightDetailsEntities11 : DbContext
    {
        public FlightDetailsEntities11()
            : base("name=FlightDetailsEntities11")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<FlightDetail> FlightDetails { get; set; }
        public virtual DbSet<scheduleflight> scheduleflights { get; set; }
    }
}
