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
    public partial class AddProdus : Form
    {
        public String Denumire { get; set; }
        public decimal PretUnitar { get; set; }
        public bool changed { get; set; } = false;

        public AddProdus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Introduceti un nume pentru produs!");
                return;
            }
            if (!decimal.TryParse(textBox2.Text, out decimal q))
            {
                MessageBox.Show("Introduceti un pret unitar pentru produs!");
                return;
            }
           
            Denumire = textBox1.Text;
            PretUnitar = q;
            changed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
