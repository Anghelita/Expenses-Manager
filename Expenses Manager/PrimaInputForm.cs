using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Manager
{
    public partial class PrimaInputForm : Form
    {
        public PrimaInputForm(int id_angajat)
        {
            InitializeComponent();

            btOK.Click += (sender, e) => btOK_Click(id_angajat);
        }

        private void btOK_Click(int id_angajat)
        {
            decimal suma = decimal.Parse(tbPrima.Text);

            using (var context = new HramulEntities())
            {
                State_de_plata stat = new State_de_plata
                {
                    ID_ANGAJAT = id_angajat,
                    Suma = suma,
                    Data = DateTime.Today,
                    TIP_PLATA = "PRIMA"
                };

                context.State_de_platas.Add(stat);
                context.SaveChanges();
            }

            Hide();
        }
    }
}
