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
    public partial class FacturaForm : Form
    {
        public String Date { get; set; }
        public int number { get; set; }
        public String Tip { get; set; }
        public String Observatii { get; set; }

        public bool Canceled { get; set; } = true;

        public FacturaForm(List<Bucket> bucket)
        {           
            InitializeComponent();
            dataGridView1.DataSource = bucket;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;

            if (!int.TryParse(numarTextBox.Text, out a))
            {
                MessageBox.Show("Numarul Facuturii nu este corect!");
                return;
            }
            Date = dateTimePicker.Text;
            number = Convert.ToInt32(numarTextBox.Text);
            Tip = "ITU";
            Observatii = observatiiTextBox.Text;

            Canceled = false;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Canceled = true;
            this.Close();
        }
    }
}
