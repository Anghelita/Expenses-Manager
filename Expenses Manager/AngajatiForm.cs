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
    public partial class AngajatiForm : Form
    {
        public AngajatiForm()
        {
            InitializeComponent();

            FillQuerries();
        }

        private void FillQuerries()
        {
            using (var context = new HramulEntities())
            {
                var results = from a in context.Angajatis
                              join d in context.Departamentes
                              on a.ID_DEPARTAMENT equals d.ID_DEPARTAMENT
                              join s in context.State_de_platas
                              on a.ID_ANGAJAT equals s.ID_ANGAJAT
                              where s.TIP_PLATA.Equals("SALARIU")
                              orderby a.Nume
                              select new
                              {
                                  a.ID_ANGAJAT,
                                  a.Nume,
                                  a.Prenume,
                                  a.Adresa,
                                  a.Rating,
                                  a.Functie,
                                  a.Activ,
                                  d.Denumire,
                                  s.Suma
                              };
                dataGridView.DataSource = results.ToList();

                tssNumarAngajati.Text = "Total Angajati: " +
                                         (from a in context.Angajatis
                                          select a).Count();

                tssTotalSalarii.Text = "Total salarii: " + 
                                        (from a in context.SalariiCurentes
                                         select a.Salariu).Sum();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;

            using (var context = new HramulEntities())
            {
                var results = (from a in context.Angajatis.DefaultIfEmpty()
                               join d in context.Departamentes
                               on a.ID_DEPARTAMENT equals d.ID_DEPARTAMENT
                               join s in context.State_de_platas
                               on a.ID_ANGAJAT equals s.ID_ANGAJAT
                               where s.TIP_PLATA.Equals("SALARIU")
                               where a.Nume.StartsWith(name)
                               orderby a.Nume
                               select new
                               {
                                   a.ID_ANGAJAT,
                                   a.Nume,
                                   a.Prenume,
                                   a.Adresa,
                                   a.Rating,
                                   a.Functie,
                                   a.Activ,
                                   d.Denumire,
                                   s.Suma
                               }).ToList();

                if( results.Count == 0)
                {
                    MessageBox.Show("Niciun angajat nu a fost gasit! Va rugam sa reintroduceti datele!");
                }

                dataGridView.DataSource = results;
            }
        }

        private void tbSearch_MouseDown(object sender, MouseEventArgs e)
        {
            tbSearch.Text = "";
            tbSearch.ForeColor = Color.Black;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string name = tbSearch.Text;

            using (var context = new HramulEntities())
            {
                var results = (from a in context.Angajatis
                               join d in context.Departamentes
                               on a.ID_DEPARTAMENT equals d.ID_DEPARTAMENT
                               join s in context.State_de_platas
                               on a.ID_ANGAJAT equals s.ID_ANGAJAT
                               where s.TIP_PLATA.Equals("SALARIU")
                               where a.Nume.StartsWith(name)
                               orderby a.Nume
                               select new
                               {
                                   a.ID_ANGAJAT,
                                   a.Nume,
                                   a.Prenume,
                                   a.Adresa,
                                   a.Rating,
                                   a.Functie,
                                   a.Activ,
                                   d.Denumire,
                                   s.Suma
                               }).ToList();

                dataGridView.DataSource = results;
            }
        }

        private void btAdauga_Click(object sender, EventArgs e)
        {
            Form form = new AdaugaAngajat();
            form.ShowDialog();

            FillQuerries();
        }


        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            int row = dataGridView.HitTest(e.X, e.Y).RowIndex;
            var value = dataGridView.Rows[row].Cells[0].FormattedValue;
            MessageBox.Show(value.ToString());
        }
    }
}
