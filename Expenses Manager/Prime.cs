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
    
    public partial class Prime
    {
        public int ID_PRIMA { get; set; }
        public Nullable<int> ID_ANGAJAT { get; set; }
        public string Descriere { get; set; }
        public decimal Suma { get; set; }
    
        public virtual Angajati Angajati { get; set; }
    }
}
