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
    public partial class AddClientForm : Form
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }


        public AddClientForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (numeTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduceti un nume pentru client!");
                return;
            }
            if (adresaTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduceti o adresa pentu client!");
                return;
            }
            if (!int.TryParse(numarTelefonTextBox.Text, out int q))
            {
                MessageBox.Show("Numar bucati gresit!");
                return;
            }
            Nume = numarTelefonTextBox.Text;
            Adresa = adresaTextBox.Text;
            Telefon = numarTelefonTextBox.Text;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
