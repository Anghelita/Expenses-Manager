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
    
    public partial class Achizitii
    {
        public int ID_ACHIZITIE { get; set; }
        public Nullable<int> ID_PRODUS { get; set; }
        public Nullable<int> Numar_de_bucati { get; set; }
        public Nullable<int> ID_FACTURA { get; set; }
        public Nullable<decimal> Pret_Unitar { get; set; }
        public Nullable<int> ID_DEPOZIT { get; set; }
        public Nullable<int> ID_FURNIZOR { get; set; }
    
        public virtual Depozite Depozite { get; set; }
        public virtual Furnizori Furnizori { get; set; }
        public virtual Facturi Facturi { get; set; }
        public virtual Produse Produse { get; set; }
    }
}
