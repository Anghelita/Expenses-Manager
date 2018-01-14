using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expenses_Manager
{
    public class Bucket
    {
        [DisplayName("Nume produs")]
        public string NumeProdus { get ; set; }
        [DisplayName("Numar bucati")]
        public int NumarBucati { get; set; }
        [DisplayName("Pret cumparare")]
        public decimal? PretCumparare { get; set; }
        [DisplayName("Pret vanzare")]
        public decimal? PretVanzare { get; set; }
        [DisplayName("Adresa depozit")]
        public string Depozit { get; set; }
        [DisplayName("Nume furnizor")]
        public string Furnizor { get; set; }
    }
}
