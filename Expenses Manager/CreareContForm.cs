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

            btInregistreaza.Click += (sender, e) => btInregistreaza_Click(id_angajat);
        }

        private void btInregistreaza_Click(int id_angajat)
        {
            string username = tbUtilizator.Text;
            string parola = tbParola.Text;
            byte[] hash = MD5.Create().ComputeHash(ASCIIEncoding.ASCII.GetBytes(parola));

            User user = new User
            {
                Username = username,
                Password = hash,
                ID_ANGAJAT = id_angajat
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
