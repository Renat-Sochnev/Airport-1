//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airport.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int IDFlight { get; set; }
        public Nullable<System.DateTime> DepartureDate { get; set; }
        public Nullable<System.DateTime> ArivalDate { get; set; }
        public Nullable<int> IDFlyghtport { get; set; }
        public Nullable<int> IDBortworker1 { get; set; }
        public Nullable<int> IDBortworker2 { get; set; }
        public Nullable<int> IDBortworker3 { get; set; }
        public Nullable<int> IDFlightStatus { get; set; }
        public Nullable<int> IDAirplane { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Airplane Airplane { get; set; }
        public virtual FlightStatus FlightStatus { get; set; }
        public virtual Flyghtport Flyghtport { get; set; }
        public virtual Worker Worker { get; set; }
        public virtual Worker Worker1 { get; set; }
        public virtual Worker Worker2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
