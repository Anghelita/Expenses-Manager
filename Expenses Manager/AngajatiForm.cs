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

            InitializeMyComponenets();
        }

        private void InitializeMyComponenets()
        {
            using (var context = new HramulEntities())
            {
                var results = from a in context.Angajatis
                              join d in context.Departamentes
                              on a.ID_DEPARTAMENT equals d.ID_DEPARTAMENT
                              join aa in context.SalariiCurentes
                              on a.ID_ANGAJAT equals aa.ID_ANGAJAT
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
                                  aa.Salariu
                              };
                dataGridView.DataSource = results.ToList();

                tssNumarAngajati.Text = "Total Angajati: " +
                                         (from a in context.Salariis
                                          select a).Count();

                tssTotalSalarii.Text = "Total salarii: " +
                                        (from a in context.Salariis
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
                               where s.Data.Value.Year == DateTime.Today.Year
                               where s.Data.Value.Month == DateTime.Today.Month
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
                               where s.Data.Value.Year == DateTime.Today.Year
                               where s.Data.Value.Month == DateTime.Today.Month
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

            InitializeMyComponenets();
        }

        private void menuItemSterge_Click(int id_angajat)
        {
            using (var context = new HramulEntities())
            {

                var angajat = (from a in context.Angajatis
                                 where a.ID_ANGAJAT == id_angajat
                                 select a).First();

                if (angajat.Activ == true)
                {
                    angajat.Activ = false;
                    MessageBox.Show("Angajatul a fost trecut inactiv");
                }
                else if(angajat.Activ == false)
                {
                    angajat.Activ = true;
                    MessageBox.Show("Angajatul a fost trecut activ");
                }

                context.SaveChanges();

                InitializeMyComponenets();
            }
        }

        private void menuItemActualizeaza_Click(int id_angajat)
        {
            using (var context = new HramulEntities())
            {
                Form form = new ActualizeazaAngajat(id_angajat);
                form.ShowDialog();

                InitializeMyComponenets();
            }
        }

        private void menutItemPrima_Click(int id_angajat)
        {
            Form form = new PrimaInputForm(id_angajat);
            form.ShowDialog();

            MessageBox.Show("Prima a fost adaugata");

            using (var context = new HramulEntities())
            {
                var results = from s in context.State_de_platas
                              where s.ID_ANGAJAT == id_angajat
                              select new
                              {
                                  s.ID_PLATA,
                                  s.Suma,
                                  s.TIP_PLATA,
                                  s.Data
                              };

                dataGridViewState.DataSource = results.ToList();
            }
        }

        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int row = dataGridView.HitTest(e.X, e.Y).RowIndex;
                var id_angajat = int.Parse(dataGridView.Rows[row].Cells[0].FormattedValue.ToString());

                if (e.Button == MouseButtons.Left)
                {
                    using (var context = new HramulEntities())
                    {
                        var results = from s in context.State_de_platas
                                      where s.ID_ANGAJAT == id_angajat
                                      select new
                                      {
                                          s.ID_PLATA,
                                          s.Suma,
                                          s.TIP_PLATA,
                                          s.Data
                                      };

                        dataGridViewState.DataSource = results.ToList();
                    }
                }

                if(e.Button == MouseButtons.Right)
                {
                    ContextMenu menu = new ContextMenu();
                    menu.MenuItems.Add(new MenuItem("Seteaza activ/inactiv", (s, ev) => menuItemSterge_Click(id_angajat)));
                    menu.MenuItems.Add(new MenuItem("Actualizeaza", (s, ev) => menuItemActualizeaza_Click(id_angajat)));
                    menu.MenuItems.Add(new MenuItem("Adauga prima", (s, ev) => menutItemPrima_Click(id_angajat)));

                    menu.Show(dataGridView, new Point(e.X, e.Y));
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Esti in afara numarului de randuri din grid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
