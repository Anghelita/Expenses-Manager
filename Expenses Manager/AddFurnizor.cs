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
    public partial class AddFurnizor : Form
    {
        private Furnizori context;
        private bool changed = false;


        public AddFurnizor(String name)
        {
            context = new Furnizori();
            InitializeComponent();
            numeTextBox.Text = name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (numeTextBox.Text.Equals("") || adresaTextBox.Text.Equals("") || cuiTextBox.Text.Equals(""))
            {
                MessageBox.Show("Date incorecte!");
                return;
            }
            context = new Furnizori() { Nume = numeTextBox.Text.ToString(), Adresa = adresaTextBox.Text.ToString(), CUI = cuiTextBox.Text.ToString() };
            changed = true;

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Furnizori getFurnizor()
        {
            return context;
        } 

        public bool getChanged()
        {
            return changed;
        }

        public void SetNameChangeable()
        {
            numeTextBox.ReadOnly = false;
        }
    }
}
