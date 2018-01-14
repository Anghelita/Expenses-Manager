using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Expenses_Manager.Forms
{
    partial class AchizitiiForm
    {
        private DbContext context = new masterEntities();

        private void tableDump<TEntity>(object sender, IQueryable<TEntity> set) where TEntity : class
        {
            DataGridView dataGridView = (DataGridView)sender;

            var cols = typeof(TEntity).GetProperties().Select(x => x.PropertyType).ToArray();

            int index = 0;
            foreach (var col in cols)
            {
                if (!(col.Name.Equals("Int32") || col.Name.Equals("String") || col.Name.Equals("Nullable`1")))
                    break;
                index++;
            }

            for (int i = index; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].Visible = false;
            }
        }

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 191);
            this.dataGridView1.TabIndex = 0;

            var dataSource = (from c in context.
                                       select c).ToList();
            dataGridView1.DataBindingComplete += (sender, e) => tableDump(sender, set);

            // 
            // AchizitiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 388);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AchizitiiForm";
            this.Text = "AchizitiiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        public object Context { get => context; set => context = value; }
    }
}