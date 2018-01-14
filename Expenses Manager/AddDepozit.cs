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
    public partial class AddDepozit : Form
    {
        private Depozite context;
        private bool changed = false;

        public AddDepozit(string depozit)
        {
            this.context = new Depozite();
            InitializeComponent();
            adresaTextBox.Text = depozit;
        }

        private void sabeButton_Click(object sender, EventArgs e)
        {
            if (adresaTextBox.Text.Equals("") || telefonTextBox.Text.Equals(""))
            {
                MessageBox.Show("Date incorecte!");
                return;
            }
            context =new Depozite() {  Adresa = adresaTextBox.Text, Telefon = telefonTextBox.Text };
            changed = true;

            this.Close();
        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool getChanged()
        {
            return changed;
        }

        public Depozite getDepozit()
        {
            return context;
        }

        public void SetAdressChangeable()
        {
            adresaTextBox.ReadOnly = false;
        }
    }
}
