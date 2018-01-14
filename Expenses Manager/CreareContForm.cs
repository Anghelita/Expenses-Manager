using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Expenses_Manager
{
    public partial class CreareContForm : Form
    {
        public CreareContForm(int id_angajat)
        {
            InitializeComponent();
        }

        private void btInregistreaza_Click(object sender, EventArgs e)
        {
            string username = tbUtilizator.Text;
            string parola = tbParola.Text;
            byte[] hash = MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(parola));

            User user = new User
            {
                Username = username,
                Password = hash
            };

            using (var context = new HramulEntities())
            {
                context.Users.Add(user);

                context.SaveChanges();

                Hide();
            }
        }
    }
}
