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

    public partial class AchizitiiForm : Form
    {
        private HramulEntities context = new HramulEntities();

        private List<Furnizori> localFurnizori;
        private List<Depozite> localDepozite;

        private List<Bucket> localbucket;
        private List<Produse> localProduse;


        public AchizitiiForm()
        {
            localFurnizori = new List<Furnizori>();
            localDepozite = new List<Depozite>();
            localbucket = new List<Bucket>();
            localProduse = new List<Produse>();
            InitializeComponent();
        }

        private void AchizitiiForm_Load(object sender, EventArgs e)
        {
            refresh();
            refresh();

            loadNumeProduse();


            var Depozite = from c in context.Depozites
                           select c.Adresa;
            foreach (String item in Depozite.ToArray())
            {
                depozitComboBox.Items.Add(item);
            }

            var Furnizori = from c in context.Furnizoris
                            select c.Nume;

            foreach (String item in Furnizori.ToArray())
            {
                furnizorComboBox.Items.Add(item);
            }

        }

        private void tableDump<TEntity>(object sender, IQueryable<TEntity> set) where TEntity : class
        {
            DataGridView dataGridView = (DataGridView)sender;

            var cols = typeof(TEntity).GetProperties().Select(x => x.PropertyType).ToArray();

            int index = 0;
            foreach (var col in cols)
            {
                if (!(col.Name.Equals("Int32") || col.Name.Equals("String") || col.Name.Equals("Nullable`1")))
                    break;
                index++;
            }

            for (int i = index; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
        }

        private void veziListaButton_Click(object sender, EventArgs e)
        {
            BucketListForm bucketListForm = new BucketListForm(localbucket);
            bucketListForm.ShowDialog();
        }


        private void adaugaProdusButton_Click(object sender, EventArgs e)
        {
            int q;
            decimal n, m;

            if (!Regex.IsMatch(numeProdusComboBox.Text, "^[A-Z][a-z]*"))
            {
                MessageBox.Show("Introduceti un nume pentru produs!");
                return;
            }
            if (!int.TryParse(numarBucatiTextBox.Text, out q))
            {
                MessageBox.Show("Numar bucati gresit!");
                return;
            }
            if (!decimal.TryParse(cumparareUnitateTextBox.Text, out  n))
            {
                MessageBox.Show("Pret cumparare pe unitate gresit!");
                return;
            }
            if (!decimal.TryParse(VanzareUnitateComboBox1.Text, out m))
            {
                MessageBox.Show("Pret vanzare pe unitate gresit!");
                return;
            }

            if ((!context.Depozites.Any(o => o.Adresa.Equals(depozitComboBox.Text))) &&
                !localDepozite.Exists(o => o.Adresa.Equals(depozitComboBox.Text)))
            {
                if (!this.adaugaDepozit(depozitComboBox.Text))
                    return;
            }
            if ((!context.Furnizoris.Any(o => o.Nume.Equals(furnizorComboBox.Text))) &&
                !localFurnizori.Exists(o => o.Nume.Equals(furnizorComboBox.Text)))
            {
                if (!this.adaugaFurnizor(furnizorComboBox.Text))
                    return;
            }

            localProduse.Add(this.adaugaProdus());


            localbucket.Add(new Bucket()
            {
                NumeProdus = numeProdusComboBox.Text,
                NumarBucati = Convert.ToInt16(numarBucatiTextBox.Text),
                PretCumparare = Convert.ToDecimal(cumparareUnitateTextBox.Text),
                PretVanzare = Convert.ToDecimal(VanzareUnitateComboBox1.Text),
                Depozit = depozitComboBox.Text,
                Furnizor = furnizorComboBox.Text
            });

            numeProdusComboBox.Text = "";
            numarBucatiTextBox.Text = "";
            VanzareUnitateComboBox1.Text = "";
            depozitComboBox.Text = "";
            furnizorComboBox.Text = "";

            MessageBox.Show("Produsul a fost adaugat!");
        }

        private Produse adaugaProdus()
        {
            Produse produse = new Produse()
            {
                Denumire = numeProdusComboBox.Text,
                Pret_Unitar = Convert.ToDecimal(VanzareUnitateComboBox1.Text),
                Stoc = Convert.ToInt16(numarBucatiTextBox.Text)
            };
            return produse;
        }

        private void adaugaAchizitie()
        {
            Facturi facturi = new Facturi();

            Produse produse = new Produse();
            Depozite depozite = new Depozite();
            Furnizori furnizori = new Furnizori();


            FacturaForm facturaForm = new FacturaForm(localbucket);
            facturaForm.ShowDialog();
            if (facturaForm.Canceled == true)
                return;

            facturi = new Facturi()
            {
                Data = Convert.ToDateTime(facturaForm.Date),
                Nr = facturaForm.number,
                Tip = facturaForm.Tip,
                Observatii = facturaForm.Observatii
            };
            context.Facturis.Add(facturi);
            context.SaveChanges();
            context.SaveChanges();
            context.SaveChanges();

            foreach (var item in localbucket)
            {
                if (!context.Produses.Any(o => o.Denumire.Equals(item.NumeProdus)))
                {
                    context.Produses.Add(new Produse()
                    {
                        Denumire = item.NumeProdus,
                        Pret_Unitar = item.PretVanzare,
                        Stoc = item.NumarBucati,
                    });
                }
                else
                {
                    var resoult = (from c in context.Produses
                                   where c.Denumire == item.NumeProdus
                                   select c).First();
                    resoult.Stoc += item.NumarBucati;
                    resoult.Pret_Unitar = item.PretVanzare;
                }
                context.SaveChanges();


                if (!context.Depozites.Any(o => o.Adresa.Equals(item.Depozit)))
                {
                    if (!localDepozite.Any(o => o.Adresa.Equals(item.Depozit)))
                    {
                        while (!this.adaugaDepozit(item.Depozit)) ;
                    }

                    foreach (var i in localDepozite)
                    {
                        if (i.Adresa.Equals(item.Depozit))
                        {
                            context.Depozites.Add(i);
                            break;
                        }
                    }
                }
                context.SaveChanges();

                if (!context.Furnizoris.Any(o => o.Nume.Equals(item.Furnizor)))
                {
                    if (!localFurnizori.Any(o => o.Nume.Equals(item.Furnizor)))
                    {
                        while (!this.adaugaFurnizor(item.Furnizor)) ;
                    }

                    foreach (var i in localFurnizori)
                    {
                        if (i.Nume.Equals(item.Furnizor))
                        {
                            context.Furnizoris.Add(i);
                            break;
                        }
                    }
                }
                context.SaveChanges();

                produse = (from c in context.Produses
                           where c.Denumire == item.NumeProdus && c.Pret_Unitar == item.PretVanzare
                           select c).First();
                depozite = (from c in context.Depozites
                            where c.Adresa == item.Depozit
                            select c).First();
                furnizori = (from c in context.Furnizoris
                             where c.Nume == item.Furnizor
                             select c).First();
                facturi = (from c in context.Facturis
                           where c.Nr == facturi.Nr && c.Data == facturi.Data
                           select c).First();

                context.Achizitiis.Add(new Achizitii()
                {
                    ID_PRODUS = produse.ID_PRODUS,
                    Numar_de_bucati = item.NumarBucati,
                    Pret_Unitar = item.PretCumparare,
                    ID_DEPOZIT = depozite.ID_DEPOZIT,
                    ID_FURNIZOR = furnizori.ID_FURNIZOR,
                    ID_FACTURA = facturi.ID_FACTURA
                });
                context.SaveChanges();

            }
            localFurnizori.Clear();
            localDepozite.Clear();
            localbucket.Clear();
            localProduse.Clear();
            refresh();

        }

        private void loadDepozit()
        {
            depozitComboBox.Items.Clear();
            depozitComboBox.ResetText();

            List<String> list = new List<string>();
            var iq = (from c in context.Depozites
                      select c).ToList();
            foreach (var item in iq)
            {
                list.Add(item.Adresa);
            }

            foreach (var item in localDepozite)
            {
                list.Add(item.Adresa);
            }

            foreach (var item in list)
            {
                depozitComboBox.Items.Add(item);
            }
        }
        private bool adaugaDepozit(String txt)
        {
            AddDepozit addDepozit = new AddDepozit(txt);
            if (txt.Equals(""))
            {
                addDepozit.SetAdressChangeable();
            }
            addDepozit.ShowDialog();
            if (!addDepozit.getChanged())
                return false;
            localDepozite.Add(addDepozit.getDepozit());

            this.loadDepozit();

            depozitComboBox.Refresh();
            depozitComboBox.Text = addDepozit.getDepozit().Adresa;

            return true;
        }

        private void loadFurnizor()
        {
            List<String> list = new List<string>();
            var iq = (from c in context.Furnizoris
                      select c).ToList();
            foreach (var item in iq)
            {
                list.Add(item.Nume);
            }

            foreach (var item in localFurnizori)
            {
                list.Add(item.Nume);
            }


            furnizorComboBox.Items.Clear();
            furnizorComboBox.ResetText();

            foreach (var item in list)
            {
                furnizorComboBox.Items.Add(item);
            }
        }
        private bool adaugaFurnizor(String txt)
        {
            AddFurnizor addFurnizor = new AddFurnizor(txt);
            if (txt.Equals(""))
            {
                addFurnizor.SetNameChangeable();
            }
            addFurnizor.ShowDialog();
            if (!addFurnizor.getChanged())
                return false;
            localFurnizori.Add(addFurnizor.getFurnizor());

            this.loadFurnizor();

            furnizorComboBox.Refresh();
            furnizorComboBox.Text = addFurnizor.getFurnizor().Nume;
            return true;
        }

        private void loadNumeProduse()
        {
            List<String> list = new List<string>();
            var iq = (from c in context.Produses
                      select c.Denumire).Distinct().ToList();
            foreach (var item in iq)
            {
                list.Add(item);
            }

            numeProdusComboBox.Items.Clear();
            numeProdusComboBox.ResetText();

            foreach (var item in list)
            {
                numeProdusComboBox.Items.Add(item);
            }
        }

        private void loadPretVanzare(String selected)
        {
            List<decimal?> list = new List<decimal?>();
            var iq = (from c in context.Produses
                      where c.Denumire.Equals(selected)
                      select c).ToList();
            foreach (var item in iq)
            {
                list.Add(item.Pret_Unitar);
            }

            foreach (var item in localProduse)
            {
                list.Add(item.Pret_Unitar);
            }

            VanzareUnitateComboBox1.Items.Clear();
            VanzareUnitateComboBox1.ResetText();

            foreach (var item in list)
            {
                VanzareUnitateComboBox1.Items.Add(item);
            }
        }

        private void adaugaAchizitiaButton_Click(object sender, EventArgs e)
        {
            this.adaugaAchizitie();
        }

        private void refresh()
        {
            achizitiiDataGridView.DataSource = (from c in context.AchizitiiExtendeds
                                                select c).ToList();
            achizitiiDataGridView.DataBindingComplete += (send, es) => tableDump(achizitiiDataGridView, context.Achizitiis);
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void numeProdusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPretVanzare(numeProdusComboBox.Text);
        }

        private void achizitiiTabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Achizitii> list = (from c in context.Achizitiis select c).ToList();
        }

        private void depoziToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaProduseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabelaFacturiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depozitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepozit addDepozit = new AddDepozit("");
            addDepozit.SetAdressChangeable();
            addDepozit.ShowDialog();
            if (!addDepozit.getChanged())
                return;
            context.Depozites.Add(addDepozit.getDepozit());
            context.SaveChanges();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.adaugaAchizitie();
        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProdus addProdus = new AddProdus();
            addProdus.ShowDialog();
            if (!addProdus.changed)
                return;

            context.Produses.Add(new Produse()
            {
                Denumire = addProdus.Denumire,
                Pret_Unitar = addProdus.PretUnitar,
                Stoc = 0
            });
            context.SaveChanges();
        }

        private void furnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFurnizor addFurnizor = new AddFurnizor("");
            addFurnizor.SetNameChangeable();
            addFurnizor.ShowDialog();
            if (!addFurnizor.getChanged())
                return;

            context.Furnizoris.Add(addFurnizor.getFurnizor());
            context.SaveChanges();
        }
    }
}

