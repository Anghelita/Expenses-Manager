//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Expenses_Manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturi()
        {
            this.Achizitiis = new HashSet<Achizitii>();
            this.Comanda_Detalii = new HashSet<Comanda_Detalii>();
            this.Plati_servicii = new HashSet<Plati_servicii>();
        }
    
        public int ID_FACTURA { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<int> Nr { get; set; }
        public string Tip { get; set; }
        public string Observatii { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Achizitii> Achizitiis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda_Detalii> Comanda_Detalii { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plati_servicii> Plati_servicii { get; set; }
    }
}
