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

            using (var context =new HramulEntities())
            {
                var results = from a in context.SalariiCurentes
                              orderby a.Nume
                              select a;
                dataGridView.DataSource = results.ToList();

                tssNumarAngajati.Text += (from a in context.Angajatis
                                          select a).Count();

                tssTotalSalarii.Text += (from a in context.SalariiCurentes
                                        select a.Salariu).Sum();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbSearch.Text;

            using (var context = new HramulEntities())
            {
                var results = (from a in context.SalariiCurentes
                               orderby a.Nume
                               where a.Nume.StartsWith(name)
                               select a).ToList();

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
                var results = (from a in context.SalariiCurentes
                               orderby a.Nume
                               where a.Nume.StartsWith(name)
                               select a).ToList();

                dataGridView.DataSource = results;
            }
        }
    }
}
