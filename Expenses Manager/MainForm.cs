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

namespace Expenses_Manager
{
    public partial class MainForm : Form
    {
        private bool LOGGED_IN = false;
        private string DEPARTAMENT;

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
            //if (!LOGGED_IN)
            //{
            //    MessageBox.Show("Nu sunteti logat", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if(!DEPARTAMENT.Equals("Human Resources"))
            //{
            //    MessageBox.Show("Nu apartineti departamentului de resurse umane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

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

                    LOGGED_IN = true;

                    DEPARTAMENT = (from u in context.Users
                                   join a in context.Angajatis
                                   on u.ID_ANGAJAT equals a.ID_ANGAJAT
                                   join d in context.Departamentes
                                   on a.ID_ANGAJAT equals d.ID_DEPARTAMENT
                                   select d.Denumire).First();

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

        }

        private void btDataBase_Click(object sender, EventArgs e)
        {

        }
    }
}
