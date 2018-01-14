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
            if (numeProdusTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduceti un nume pentru produs!");
                return;
            }
            if (!int.TryParse(numarBucatiTextBox.Text, out int q))
            {
                MessageBox.Show("Numar bucati gresit!");
                return;
            }
            if (!int.TryParse(pretUnitatetextBox.Text, out int n))
            {
                MessageBox.Show("Pret unitate gresit!");
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
                NumeProdus = numeProdusTextBox.Text,
                NumarBicati = Convert.ToInt16(numarBucatiTextBox.Text),
                PretUnimate = Convert.ToInt16(pretUnitatetextBox.Text),
                Depozit = depozitComboBox.Text,
                Furnizor = furnizorComboBox.Text
            });

            numeProdusTextBox.Text = "";
            numarBucatiTextBox.Text = "";
            pretUnitatetextBox.Text = "";
            depozitComboBox.Text = "";
            furnizorComboBox.Text = "";

            MessageBox.Show("Produsul a fost adaugat!");
        }

        private Produse adaugaProdus()
        {
            Produse produse = new Produse()
            {
                Denumire = numeProdusTextBox.Text,
                Pret_Unitar = Convert.ToInt16(pretUnitatetextBox.Text),
                Stoc = Convert.ToInt16(numarBucatiTextBox.Text)

            };
            return produse;
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
            addFurnizor.ShowDialog();
            if (!addFurnizor.getChanged())
                return false;
            localFurnizori.Add(addFurnizor.getFurnizor());

            this.loadFurnizor();

            furnizorComboBox.Refresh();
            furnizorComboBox.Text = addFurnizor.getFurnizor().Nume;
            return true;
        }

        private void adaugaAchizitiaButton_Click(object sender, EventArgs e)
        {
            foreach (var item in localbucket)
            {
                
                Produse produse = new Produse();
                Depozite depozite = new Depozite();
                Furnizori furnizori = new Furnizori();
                Facturi facturi = new Facturi();


                FacturaForm facturaForm = new FacturaForm(new List<Bucket> { item });
                facturaForm.ShowDialog();
                if (facturaForm.Canceled == true)
                    continue;

                facturi = new Facturi()
                {
                    Data = Convert.ToDateTime(facturaForm.Date),
                    Nr = facturaForm.number,
                    Tip = facturaForm.Tip,
                    Observatii = facturaForm.Observatii
                };

                context.Facturis.Add(facturi);
                context.SaveChanges();

                if (!context.Produses.Any(o => o.Denumire.Equals(item.NumeProdus)))
                {
                    context.Produses.Add(new Produse()
                    {
                        Denumire = item.NumeProdus,
                        Pret_Unitar = item.PretUnimate,
                        Stoc = item.NumarBicati
                    });
                }
                else
                {
                    var res = (from c in context.Produses
                               where c.Denumire == item.NumeProdus
                               select c);
                    foreach (var i in res)
                    {
                        if (i.Pret_Unitar == item.PretUnimate)
                        {
                            i.Stoc += item.NumarBicati;
                        }
                    }
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
                    if (!localFurnizori.Any(o => o.Adresa.Equals(item.Furnizor)))
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
                            where c.Denumire == item.NumeProdus && c.Pret_Unitar == item.PretUnimate
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
                    Numar_de_bucati = item.NumarBicati,
                    Pret_Unitar = item.PretUnimate,
                    ID_DEPOZIT = depozite.ID_DEPOZIT,
                    ID_FURNIZOR = furnizori.ID_FURNIZOR,
                    ID_FACTURA = facturi.ID_FACTURA
                });
                context.SaveChanges();
            }
        }

        private void refresh()
        {
            achizitiiDataGridView.DataSource = (from c in context.Achizitiis
                                                select c).ToList();
            achizitiiDataGridView.DataBindingComplete += (send, es) => tableDump(achizitiiDataGridView, context.Achizitiis);
        }

        private void refreshbutton_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
