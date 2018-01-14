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
    public partial class ActualizeazaAngajat : AdaugaAngajat
    {
        public ActualizeazaAngajat(int id_angajat)
        {
            InitializeComponent();

            using (var context = new HramulEntities())
            {
                Angajati angajat = (from a in context.Angajatis
                                    where a.ID_ANGAJAT == id_angajat
                                    select a).First();

                tbNume.Text = angajat.Nume;
                tbPrenume.Text = angajat.Prenume;
                tbFunctie.Text = angajat.Functie;
                tbAdresa.Text = angajat.Adresa;
                cbRating.Text = angajat.Rating.ToString();

                cbDepartament.Text = (from d in context.Departamentes
                                      where d.ID_DEPARTAMENT == angajat.ID_DEPARTAMENT
                                      select d.Denumire).First();

                tbSalariu.Text = (from s in context.State_de_platas
                                  where s.TIP_PLATA.Equals("SALARIU")
                                  where s.ID_ANGAJAT == 12
                                  select s.Suma).First().ToString();

                btSalveaza.Name = "Actualizeaza";
                btSalveaza.Text = "Actualizeaza";
                btSalveaza.Click -= btSalveaza_Click;
                btSalveaza.Click += (sender, e) => btActualizeaza_Click(id_angajat);

                FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }

        }

        private void btActualizeaza_Click(int id_angajat)
        {
            string nume = null, prenume = null, adresa = null, functie = null, denumire = null;
            decimal salariu = 0;
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
                Angajati angajat = (from a in context.Angajatis
                                   where a.ID_ANGAJAT == id_angajat
                                   select a).First();

                State_de_plata stat = (from s in context.State_de_platas
                                       where s.ID_ANGAJAT == id_angajat
                                       where s.Data.Value.Year == DateTime.Today.Year
                                       where s.Data.Value.Month == DateTime.Today.Month
                                       select s).First();

                Departamente departament = (from d in context.Departamentes
                                            where d.ID_DEPARTAMENT == angajat.ID_DEPARTAMENT
                                            select d).First();

                angajat.Nume = nume;
                angajat.Prenume = prenume;
                angajat.Functie = functie;
                angajat.Rating = rating;
                angajat.Adresa = adresa;

                departament.Denumire = denumire;

                stat.Suma = salariu;

                context.SaveChanges();
            }

            MessageBox.Show("Angajatul a fost actualizat!");

            Hide();
        }
    }
}
