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

        List<Facturi> facturiQuery;
        List<Angajati> angajatiQuery;
        List<Clienti> clientiQuery;
        List<Produse> produseQuery;
        List<OrderDetailsExtended> listOrders;

        private void RefreshGridView()
        {
            GridViewComenzi.DataSource = (from c in context.ComenziExtendeds select c).ToList();
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

        int orderID;

        public ComenziForm()
        {
            InitializeComponent();

            RefreshGridView();

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
                context.MakeOrder(1, DateTime.Parse(date), client_ID, ordID);
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
    }
}
