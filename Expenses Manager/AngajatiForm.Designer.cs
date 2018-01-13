namespace Expenses_Manager
{
    partial class AngajatiForm
    {
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btCauta = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNumarAngajati = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTotalSalarii = new System.Windows.Forms.ToolStripStatusLabel();
            this.btAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(647, 601);
            this.dataGridView.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbSearch.Location = new System.Drawing.Point(12, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(307, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.Text = "Introduceti numele angajatului";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDown);
            // 
            // btCauta
            // 
            this.btCauta.Location = new System.Drawing.Point(325, 9);
            this.btCauta.Name = "btCauta";
            this.btCauta.Size = new System.Drawing.Size(75, 23);
            this.btCauta.TabIndex = 2;
            this.btCauta.Text = "Cauta";
            this.btCauta.UseVisualStyleBackColor = true;
            this.btCauta.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNumarAngajati,
            this.tssTotalSalarii});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNumarAngajati
            // 
            this.tssNumarAngajati.Name = "tssNumarAngajati";
            this.tssNumarAngajati.Size = new System.Drawing.Size(95, 17);
            this.tssNumarAngajati.Text = "Numar angajati: ";
            // 
            // tssTotalSalarii
            // 
            this.tssTotalSalarii.Name = "tssTotalSalarii";
            this.tssTotalSalarii.Size = new System.Drawing.Size(73, 17);
            this.tssTotalSalarii.Text = "Total Salarii: ";
            // 
            // btAdauga
            // 
            this.btAdauga.Location = new System.Drawing.Point(681, 80);
            this.btAdauga.Name = "btAdauga";
            this.btAdauga.Size = new System.Drawing.Size(191, 44);
            this.btAdauga.TabIndex = 4;
            this.btAdauga.Text = "Adauga";
            this.btAdauga.UseVisualStyleBackColor = true;
            // 
            // AngajatiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btAdauga);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btCauta);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dataGridView);
            this.Name = "AngajatiForm";
            this.Text = "AngajatiForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btCauta;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssNumarAngajati;
        private System.Windows.Forms.ToolStripStatusLabel tssTotalSalarii;
        private System.Windows.Forms.Button btAdauga;
    }
}