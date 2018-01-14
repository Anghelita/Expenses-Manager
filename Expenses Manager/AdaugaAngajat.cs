using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Manager
{
    public partial class AdaugaAngajat : Form
    {
        public AdaugaAngajat()
        {
            InitializeComponent();

            InitializeMyComponents();
        }


        private void InitializeMyComponents()
        {
            string[] rating = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            cbRating.DataSource = rating;

            using (var context = new HramulEntities())
            {
                var results = (from d in context.Departamentes
                               select d.Denumire).ToList();

                cbDepartament.DataSource = results;
            }
        }

        protected void btSalveaza_Click(object sender, EventArgs e)
        {
            string nume=null, prenume=null, adresa=null, functie=null, denumire=null;
            decimal salariu=0;
            double rating = 1;

            try
            {
                if (Regex.IsMatch(tbNume.Text, "^[A-Z][a-z]*")) nume = tbNume.Text;
                else throw new Exception("Numele trebuie sa contina doar litere si sa inceapa cu litera mare");

                if (Regex.IsMatch(tbPrenume.Text, "[A-Z][a-z]*")) prenume = tbPrenume.Text;
                else throw new Exception("Prenumele trebuie sa contina doar litere si sa inceapa cu litera mare");

                if (!tbAdresa.Text.Equals("")) adresa = tbAdresa.Text;
                else throw new Exception("Adresa trebuie sa nu fie nula");

                rating = double.Parse(cbRating.SelectedValue.ToString());

                if (Regex.IsMatch(tbFunctie.Text, "[A-Z][a-z]*")) functie = tbFunctie.Text;
                else throw new Exception("Functia trebuie sa contina doar litere si sa inceapa cu litera mare");

                salariu = decimal.Parse(tbSalariu.Text);
                denumire = cbDepartament.SelectedValue.ToString();
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Salariul trebuie sa fie de tip float", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            using (var context = new HramulEntities())
            {
                Departamente departament = (from d in context.Departamentes
                                           where d.Denumire.Equals(denumire)
                                           select d).First();

                Angajati angajat = new Angajati
                {
                    Nume = nume,
                    Prenume = prenume,
                    Adresa = adresa,
                    Rating = rating,
                    Functie = functie,
                    Activ = true,
                    Departamente = departament
                };

                State_de_plata stat = new State_de_plata
                {
                    Suma = salariu,
                    TIP_PLATA = "SALARIU",
                    Data = DateTime.Today,
                    Angajati = angajat
                };


                context.Angajatis.Add(angajat);
                context.State_de_platas.Add(stat);

                context.SaveChanges();

                MessageBox.Show("Angajatul a fost adaugat!");

                Hide();
            }

        }
    }
}
