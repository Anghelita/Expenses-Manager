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
    public partial class BucketListForm : Form
    {
        public List<Bucket> list;

        public BucketListForm(List<Bucket> list)
        {
            this.list = list;
            InitializeComponent();           
            dataGridView1.DataSource = list;
        }



    }
}
