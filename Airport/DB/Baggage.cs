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
    
    public partial class Baggage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Baggage()
        {
            this.Ticket = new HashSet<Ticket>();
        }
    
        public int IDBaggage { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<int> Lenght { get; set; }
        public Nullable<int> Height { get; set; }
        public Nullable<int> IDClient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Ticket { get; set; }
    }
}
