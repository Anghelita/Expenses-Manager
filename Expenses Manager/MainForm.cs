using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Expenses_Manager
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            using (var context = new HramulEntities())
            {
                //tssCheltuieli.Text = from c in context.
                
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

        private void btAchizitii_Click(object sender, EventArgs e)
        {
            Form form = new AchizitiiForm();
            form.Show();
        }
    }
}
