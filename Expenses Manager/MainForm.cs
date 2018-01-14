using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Manager
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            using (var context = new HramulEntities())
            {
                ObjectParameter cheltuieli = new ObjectParameter("Cheltuieli", typeof(decimal));
                ObjectParameter castiguri = new ObjectParameter("Castiguri", typeof(decimal));

                context.CalculateProfit(cheltuieli,castiguri);

                tssCheltuieli.Text += cheltuieli.Value;
                tssCastiguri.Text += castiguri.Value;
                
            }
        }

        private void btAngajati_Click(object sender, EventArgs e)
        {
            Form form = new AngajatiForm();
            form.Show();
        }

        private void tdUserName_MouseDown(object sender, MouseEventArgs e)
        {
            tbUserName.Text = "";
            tbUserName.ForeColor = Color.Black;
        }

        private void tbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.Text = "";
            tbPassword.ForeColor = Color.Black;
        }
    }
}
