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
    
    public partial class Angajati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Angajati()
        {
            this.State_de_plata = new HashSet<State_de_plata>();
            this.Comenzis = new HashSet<Comenzi>();
        }
    
        public int ID_ANGAJAT { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public Nullable<double> Rating { get; set; }
        public string Functie { get; set; }
        public string Username { get; set; }
        public Nullable<bool> Activ { get; set; }
        public string Hash { get; set; }
        public Nullable<int> ID_DEPARTAMENT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<State_de_plata> State_de_plata { get; set; }
        public virtual Departamente Departamente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comenzi> Comenzis { get; set; }
    }
}
