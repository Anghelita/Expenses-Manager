using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using iTextSharp.text.pdf;
using System.IO;

namespace Expenses_Manager
{
    public partial class MainForm : Form
    {
        private bool LOGGED_IN = false;
        private string DEPARTAMENT;
        private int ID_ANGAJAT;

        public MainForm()
        {
            InitializeComponent();

            using (var context = new HramulEntities())
            {
                ObjectParameter cheltuieli = new ObjectParameter("Cheltuieli", typeof(decimal));
                ObjectParameter castiguri = new ObjectParameter("Castiguri", typeof(decimal));

                context.CalculateProfit(cheltuieli,castiguri);

                tssCheltuieli.Text += cheltuieli.Value;
                tssCastiguri.Text += castiguri.Value;

                lbDate.Text = DateTime.Today.ToString();
                
            }
        }

        private void btAngajati_Click(object sender, EventArgs e)
        {
            if (!LOGGED_IN)
            {
                MessageBox.Show("Nu sunteti logat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DEPARTAMENT.Equals("Human Resources"))
            {
                MessageBox.Show("Nu apartineti departamentului de resurse umane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserName.Text;
            string parola = tbPassword.Text;

            using (var context = new HramulEntities())
            {
                try
                {
                    User user = (from u in context.Users
                                 where u.Username.Equals(userName)
                                 select u).First();

                    byte[] hash = MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(parola));
                    byte[] userHash = user.Password;

                    for(int i = 0; i < hash.Count(); i++)
                    {
                        if (hash[i] != userHash[i])
                            throw new Exception();
                    }

                    tbUserName.Hide();
                    tbPassword.Hide();
                    btLogin.Hide();

                    lbLogin.Visible = true;
                    lbLogin.Text += userName;
                    btLogout.Visible = true;

                    LOGGED_IN = true;

                    DEPARTAMENT = (from d in context.Departamentes
                                   join a in context.Angajatis
                                   on d.ID_DEPARTAMENT equals a.ID_DEPARTAMENT
                                   join u in context.Users
                                   on a.ID_ANGAJAT equals u.ID_ANGAJAT
                                   where u.ID_ANGAJAT == user.ID_ANGAJAT
                                   select d.Denumire
                                   ).First();

                    ID_ANGAJAT = (int)user.ID_ANGAJAT;

                }
                catch(Exception exception)
                {
                    MessageBox.Show("Username-ul/parolele nu se potrivesc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = "raport.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Salarii");

            //Salarii
            worksheet.Cells[0, 0] = new Cell("Id");
            worksheet.Cells[0, 1] = new Cell("Nume");
            worksheet.Cells[0, 2] = new Cell("Preume");
            worksheet.Cells[0, 3] = new Cell("Functie");
            worksheet.Cells[0, 4] = new Cell("Rating");
            worksheet.Cells[0, 5] = new Cell("Salariu");

            using (var context = new HramulEntities())
            {
                var angajati = (from a in context.Salariis
                                select a).ToList();

                int row = 1;

                foreach(var angajat in angajati)
                {
                    worksheet.Cells[row, 0] = new Cell(angajat.ID_ANGAJAT);
                    worksheet.Cells[row, 1] = new Cell(angajat.Nume);
                    worksheet.Cells[row, 2] = new Cell(angajat.Prenume);
                    worksheet.Cells[row, 3] = new Cell(angajat.Functie);
                    worksheet.Cells[row, 4] = new Cell(angajat.Rating);
                    worksheet.Cells[row, 5] = new Cell(angajat.Salariu);

                    row++;
                }
            }

            workbook.Worksheets.Add(worksheet);

            //Facturi emise
            worksheet = new Worksheet("Facturi emise");

            worksheet.Cells[0, 0] = new Cell("Nr");
            worksheet.Cells[0, 1] = new Cell("Bani");
            worksheet.Cells[0, 2] = new Cell("Observatii");
            worksheet.Cells[0, 3] = new Cell("Data");

            using (var context = new HramulEntities())
            {
                int row = 1;

                var facturi = (from f in context.FacturiEmises
                               select f).ToList();

                foreach(var factura in facturi)
                {
                    worksheet.Cells[row, 0] = new Cell(factura.Nr);
                    worksheet.Cells[row, 1] = new Cell(factura.Bani);
                    worksheet.Cells[row, 2] = new Cell(factura.Observatii);
                    worksheet.Cells[row, 3] = new Cell(factura.Data);
                }

                row++;
            }

            workbook.Worksheets.Add(worksheet);

            worksheet = new Worksheet("Facturi primite");

            worksheet.Cells[0, 0] = new ExcelLibrary.SpreadSheet.Cell("Nr");
            worksheet.Cells[0, 1] = new Cell("Bani");
            worksheet.Cells[0, 2] = new Cell("Observatii");
            worksheet.Cells[0, 3] = new Cell("Data");

            using (var context = new HramulEntities())
            {
                int row = 1;

                var facturi = (from f in context.FacturiPrimites
                               select f).ToList();

                foreach (var factura in facturi)
                {
                    worksheet.Cells[row, 0] = new Cell(factura.Nr);
                    worksheet.Cells[row, 1] = new Cell(factura.Bani);
                    worksheet.Cells[row, 2] = new Cell(factura.Observatii);
                    worksheet.Cells[row, 3] = new Cell(factura.Data);
                }

                row++;
            }

            workbook.Worksheets.Add(worksheet);

            workbook.Save(file);

            MessageBox.Show("Raportul a fost generat!");
        }

        private void btDataBase_Click(object sender, EventArgs e)
        {
            using (var context = new HramulEntities())
            {
                var angajati = (from a in context.Salariis
                                select a).ToList();

                DataGridView grid = new DataGridView();
                grid.DataSource = angajati;

                Controls.Add(grid);
                Controls.Remove(grid);

                PdfPTable pdfTable = new PdfPTable(grid.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 60;
                pdfTable.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                pdfTable.DefaultCell.BorderWidth = 1;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.Color(240, 240, 240);
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in grid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pdfTable.AddCell(cell.Value.ToString());
                    }
                }

                string file = "DataBaseExport.pdf";
                using (FileStream stream = new FileStream(file, FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();
                }
            }

            MessageBox.Show("Baza de date a fost exportata");
        }

        private void btAchizitii_Click(object sender, EventArgs e)
        {

            try
            {
                Form form = new AchizitiiForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Oh nu ceva nu a mers cum trebuie!");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();


            if (!LOGGED_IN)
            {
                MessageBox.Show("Nu sunteti logat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DEPARTAMENT.Equals("Sales"))
            {
                MessageBox.Show("Nu sunteti din departamentul de vanzari", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form form = new AchizitiiForm();
            form.Show();

        }

        private void btComenzi_Click(object sender, EventArgs e)
        {
            if (!LOGGED_IN)
            {
                MessageBox.Show("Nu sunteti logat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DEPARTAMENT.Equals("Management"))
            {
                MessageBox.Show("Nu sunteti din departamentul management", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form form = new ComenziForm.ComenziForm(ID_ANGAJAT);
            form.Show();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            LOGGED_IN = false;
            DEPARTAMENT = "";
            ID_ANGAJAT = 0;

            tbPassword.Visible = true;
            tbUserName.Visible = true;
            btLogin.Visible = true;

            lbLogin.Text = "Nume utilizator: ";
            lbLogin.Visible = false;
            btLogout.Visible = false;
        }
    }
}
