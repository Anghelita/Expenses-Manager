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
    
    public partial class ComenziExtended
    {
        public int ID_COMANDA { get; set; }
        public Nullable<System.DateTime> Data_plasare_comanda { get; set; }
        public Nullable<System.DateTime> Data_estimata_livrare { get; set; }
        public int Numar_Factura { get; set; }
        public string Angajat { get; set; }
        public string Destinatar { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}