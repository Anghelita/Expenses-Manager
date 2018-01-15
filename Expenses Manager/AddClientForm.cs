using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (!Regex.IsMatch(numeTextBox.Text, "^[A-Z][a-z]*"))
            {
                MessageBox.Show("Introduceti un nume pentru client!");
                return;
            }
            if (!Regex.IsMatch(adresaTextBox.Text, "^[A-Z][a-z]*"))
            {
                MessageBox.Show("Introduceti o adresa pentu client!");
                return;
            }
            int q;

            if (!int.TryParse(numarTelefonTextBox.Text, out q))
            {
                MessageBox.Show("Numar bucati gresit!");
                return;
            }
            Nume = numeTextBox.Text;
            Adresa = adresaTextBox.Text;
            Telefon = numarTelefonTextBox.Text;

            using (var context = new HramulEntities())
            {
                context.Clientis.Add(new Clienti()
                {
                    Nume = Nume,
                    Adresa = Adresa,
                    Telefon = Telefon
                });
                context.SaveChanges();
            }

                this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
