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
    
    public partial class Comenzi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comenzi()
        {
            this.Comanda_Detalii = new HashSet<Comanda_Detalii>();
        }
    
        public int ID_COMANDA { get; set; }
        public Nullable<System.DateTime> Data_initiere { get; set; }
        public Nullable<int> ID_FACTURA { get; set; }
        public Nullable<int> ID_ANGAJAT { get; set; }
        public Nullable<System.DateTime> Data_estimata_livrare { get; set; }
        public string Status { get; set; }
        public Nullable<int> ID_CLIENT { get; set; }
    
        public virtual Angajati Angajati { get; set; }
        public virtual Clienti Clienti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comanda_Detalii> Comanda_Detalii { get; set; }
        public virtual Facturi Facturi { get; set; }
    }
}
