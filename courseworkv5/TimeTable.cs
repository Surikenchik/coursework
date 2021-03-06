//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace courseworkv5
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TimeTable()
        {
            this.Tickets = new HashSet<Tickets>();
        }
    
        public int PassageId { get; set; }
        public string TimeTableName { get; set; }
        public int TrainNumber { get; set; }
        public int RouteId { get; set; }
        public Nullable<System.DateTime> DepartureTime { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public string Canceled { get; set; }
        public string Detained { get; set; }
        public Nullable<int> TicketPrice { get; set; }
    
        public virtual Routs Routs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual Trains Trains { get; set; }
    }
}
