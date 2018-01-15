using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Manager.ComenziForm
{
    public partial class ComenziForm : Form
    {
        private HramulEntities context = new HramulEntities();

        private int ID_ANGAJAT;

        List<Facturi> facturiQuery;
        List<Angajati> angajatiQuery;
        List<Clienti> clientiQuery;
        List<Produse> produseQuery;
        List<OrderDetailsExtended> listOrders;
        List<ComenziExtended> listComenzi;

        private void RefreshComenziView()
        {
            listComenzi = (from c in context.ComenziExtendeds select c).ToList();
            GridViewComenzi.DataSource = listComenzi;
        }

        private void RefreshPartsView()
        {
            decimal total = 0;
            var details = (from c in context.OrderDetailsExtendeds select c).ToList();
            listOrders = new List<OrderDetailsExtended>();
            try
            {
                foreach (var item in details)
                {
                    if (item.ID_COMANDA == orderID)
                    {
                        listOrders.Add(item);
                        total += (decimal)item.Subtotal;
                    }
                }
                GridViewDetalii.DataSource = listOrders;
                GridViewDetalii.Columns[0].Visible = false;
                GridViewDetalii.Columns[1].Visible = false;
                textBoxTotal.Text = total.ToString();
            }
            catch (Exception eex)
            {
                eex.ToString();
            }
        }

        private void RefreshAll()
        {
            facturiQuery = (from c in context.Facturis select c).ToList();
            List<String> listFacturi = new List<string>();
            foreach (var item in facturiQuery)
            {
                if (item.Tip.TrimEnd() == "IBU")
                {
                    comboBoxFFactura.Items.Add(item.Nr.ToString());
                    listFacturi.Add(item.Nr.ToString());
                }
            }
            angajatiQuery = (from c in context.Angajatis select c).ToList();
            List<String> listAngajati = new List<string>();
            foreach (var item in angajatiQuery)
            {
                comboBoxFAngajat.Items.Add(item.Nume + " " + item.Prenume);
                listAngajati.Add(item.Nume + " " + item.Prenume);
            }
            clientiQuery = (from c in context.Clientis select c).ToList();
            List<String> listclienti = new List<string>();
            foreach (var item in clientiQuery)
            {
                comboBoxClient.Items.Add(item.Nume);
                comboBoxFDestinatar.Items.Add(item.Nume);
                listclienti.Add(item.Nume);
            }
            comboBoxFStatus.Items.Add("In Asteptare");
            comboBoxFStatus.Items.Add("Livrata");
            comboBoxFStatus.Items.Add("Retur");
            comboBoxFStatus.Items.Add("Anulata");
            produseQuery = (from c in context.Produses select c).ToList();
            List<String> listproduse = new List<string>();
            foreach (var item in produseQuery)
            {
                comboBoxProduse.Items.Add(item.Denumire);
                listproduse.Add(item.Denumire);
            }

            RefreshComenziView();
            RefreshPartsView();
        }

        int orderID;

        public ComenziForm(int ID_ANGAJAT)
        {
            InitializeComponent();

            RefreshAll();

            this.ID_ANGAJAT = ID_ANGAJAT;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void GridViewComenzi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var newDataSource = (from c in context.ComenziExtendeds select c).ToList();
            List<ComenziExtended> finalDataSource = new List<ComenziExtended>();
            foreach (var item in newDataSource)
            {
                if (item.ID_COMANDA.ToString().Contains(TextBoxSearch.Text))
                {
                    finalDataSource.Add(item);
                }
            }
            GridViewComenzi.DataSource = finalDataSource;
        }

        private void TextBoxSearch_Enter(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text == "Introduceti Numarul Comenzii")
            {
                TextBoxSearch.Text = "";
            }
        }

        private void GridViewComenzi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void GridViewComenzi_SelectionChanged(object sender, EventArgs e)
        {
            orderID = int.Parse(GridViewComenzi.CurrentRow.Cells[0].Value.ToString());
            statuslabel_Comanda_ID.Text = "Comanda ID: " + orderID.ToString();
            RefreshPartsView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var client_name = comboBoxClient.Text;
            int client_ID = -1;
            foreach (var item in clientiQuery)
            {
                if (item.Nume == client_name)
                {
                    client_ID = item.ID_CLIENT;
                }
            }
            var date = dateTimePicker3.Value.Date.ToString();
            //TODO va lua ID ANGAJAT din username
            using (var context = new HramulEntities())
            {
                ObjectParameter empID = new ObjectParameter("EmpID", typeof(int));
                ObjectParameter cliID = new ObjectParameter("CliID", typeof(int));
                ObjectParameter ordID = new ObjectParameter("Order_ID", typeof(int));
                ObjectParameter dateest = new ObjectParameter("DateEST", typeof(DateTime));
                context.MakeOrder(ID_ANGAJAT, DateTime.Parse(date), client_ID, ordID);
                orderID = (int)ordID.Value;
                statuslabel_Comanda_ID.Text = "Comanda ID: " + orderID.ToString();

            }
            GridViewComenzi.DataSource = (from c in context.ComenziExtendeds select c).ToList();

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            var produs_name = comboBoxProduse.Text;
            int produs_ID = -1;
            decimal pret = -1;
            int stoc_current = 0;
            int cantitate = int.Parse(textBoxCantitate.Text);

            var results = (from p in context.Produses
                           select p).ToList();

            foreach (var item in results)
            {
                if (item.Denumire == produs_name)
                {
                    produs_ID = (int)item.ID_PRODUS;
                    pret = (decimal)item.Pret_Unitar;
                    stoc_current = (int)item.Stoc;
                    if (cantitate > stoc_current)
                    {
                        MessageBox.Show("Stoc insuficient");
                        return;
                    }
                    item.Stoc -= cantitate;
                }
            }
            decimal suma = pret * cantitate;
            textBoxSubtotal.Text = suma.ToString();
            context.Comanda_Detaliis.Add(new Comanda_Detalii
            {
                ID_PRODUS = produs_ID,
                Suma = suma,
                Cantitate = cantitate,
                ID_COMANDA = orderID
            });
            context.SaveChanges();
            RefreshPartsView();
        }

        private void comboBoxFFactura_TextUpdate(object sender, EventArgs e)
        {

        }

        private void comboBoxFFactura_TextChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {
                if (item.Numar_Factura.ToString() == comboBoxFFactura.Text)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void comboBoxFAngajat_TextChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Angajat == comboBoxFAngajat.Text)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void comboBoxFDestinatar_TextChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Destinatar == comboBoxFDestinatar.Text)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void comboBoxFStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFStatus_TextChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Status.Trim() == comboBoxFStatus.Text)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void textBoxExpensive_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox4.Checked)
            {
                RefreshComenziView();
            };
        }

        private void textBoxCheap_TextChanged(object sender, EventArgs e)
        {
            if (!checkBox3.Checked)
            {
                RefreshComenziView();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Total >= decimal.Parse(textBoxExpensive.Text) || !checkBox3.Checked)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Total <= decimal.Parse(textBoxCheap.Text) || !checkBox4.Checked)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void dateTimePicker2_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                RefreshComenziView();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                RefreshComenziView();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Data_plasare_comanda <= DateTime.Parse(dateTimePicker1.Text) || !checkBox1.Checked)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var items = listComenzi;
            List<ComenziExtended> newResults = new List<ComenziExtended>();
            foreach (var item in items)
            {

                if (item.Data_plasare_comanda >= DateTime.Parse(dateTimePicker2.Text) || !checkBox2.Checked)
                {
                    newResults.Add(item);
                }
            }
            GridViewComenzi.DataSource = newResults;
            listComenzi = newResults;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            RefreshComenziView();
            comboBoxFAngajat.Text = "";
            comboBoxFDestinatar.Text = "";
            comboBoxFFactura.Text = "";
            comboBoxFStatus.Text = "";
            textBoxCheap.Text = "";
            textBoxExpensive.Text = "";
        }

        private void UpdateSubtotal()
        {
            int cantitate = 0;
            if(textBoxCantitate.Text != "")
            {
                cantitate = int.Parse(textBoxCantitate.Text);
            }
            var produs_name = comboBoxProduse.Text;
            var results = (from p in context.Produses
                           select p).ToList();
            decimal pret = 0;
            int stoc_current;
            foreach (var item in results)
            {
                if (item.Denumire == produs_name)
                {
                    pret = (decimal)item.Pret_Unitar;
                    stoc_current = (int)item.Stoc;
                    if (cantitate > stoc_current)
                    {
                        MessageBox.Show("Stoc insuficient");
                        buttonAddPart.Enabled = false;
                        return;
                    }
                    buttonAddPart.Enabled = true;
                }
            }
            decimal suma = pret * cantitate;
            textBoxSubtotal.Text = suma.ToString();
        }

        private void comboBoxProduse_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void textBoxCantitate_TextChanged(object sender, EventArgs e)
        {
            UpdateSubtotal();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What were you really expecting?");
        }
    }
}
