namespace Expenses_Manager
{
    partial class AchizitiiForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depozitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achizitiiTabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depoziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaFurnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaFacturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achizitiiDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numeProdusComboBox = new System.Windows.Forms.ComboBox();
            this.VanzareUnitateComboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.veziListaButton = new System.Windows.Forms.Button();
            this.adaugaAchizitiaButton = new System.Windows.Forms.Button();
            this.adaugaProdusButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.furnizorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cumparareUnitateTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numarBucatiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depozitComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1309, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.vieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depozitToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.produsToolStripMenuItem,
            this.furnizorToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // depozitToolStripMenuItem
            // 
            this.depozitToolStripMenuItem.Name = "depozitToolStripMenuItem";
            this.depozitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.depozitToolStripMenuItem.Text = "Depozit";
            this.depozitToolStripMenuItem.Click += new System.EventHandler(this.depozitToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facturaToolStripMenuItem.Text = "Factura";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // produsToolStripMenuItem
            // 
            this.produsToolStripMenuItem.Name = "produsToolStripMenuItem";
            this.produsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produsToolStripMenuItem.Text = "Produs";
            this.produsToolStripMenuItem.Click += new System.EventHandler(this.produsToolStripMenuItem_Click);
            // 
            // furnizorToolStripMenuItem
            // 
            this.furnizorToolStripMenuItem.Name = "furnizorToolStripMenuItem";
            this.furnizorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.furnizorToolStripMenuItem.Text = "Furnizor";
            this.furnizorToolStripMenuItem.Click += new System.EventHandler(this.furnizorToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achizitiiTabelToolStripMenuItem,
            this.depoziToolStripMenuItem,
            this.tabelaFurnizoriToolStripMenuItem,
            this.tabelaProduseToolStripMenuItem,
            this.tabelaFacturiToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "View";
            // 
            // achizitiiTabelToolStripMenuItem
            // 
            this.achizitiiTabelToolStripMenuItem.Name = "achizitiiTabelToolStripMenuItem";
            this.achizitiiTabelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.achizitiiTabelToolStripMenuItem.Text = "Tabela achizitii";
            this.achizitiiTabelToolStripMenuItem.Click += new System.EventHandler(this.achizitiiTabelToolStripMenuItem_Click);
            // 
            // depoziToolStripMenuItem
            // 
            this.depoziToolStripMenuItem.Name = "depoziToolStripMenuItem";
            this.depoziToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.depoziToolStripMenuItem.Text = "Tabela depozite";
            this.depoziToolStripMenuItem.Click += new System.EventHandler(this.depoziToolStripMenuItem_Click);
            // 
            // tabelaFurnizoriToolStripMenuItem
            // 
            this.tabelaFurnizoriToolStripMenuItem.Name = "tabelaFurnizoriToolStripMenuItem";
            this.tabelaFurnizoriToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tabelaFurnizoriToolStripMenuItem.Text = "Tabela furnizori";
            this.tabelaFurnizoriToolStripMenuItem.Click += new System.EventHandler(this.tabelaFurnizoriToolStripMenuItem_Click);
            // 
            // tabelaProduseToolStripMenuItem
            // 
            this.tabelaProduseToolStripMenuItem.Name = "tabelaProduseToolStripMenuItem";
            this.tabelaProduseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tabelaProduseToolStripMenuItem.Text = "Tabela produse";
            this.tabelaProduseToolStripMenuItem.Click += new System.EventHandler(this.tabelaProduseToolStripMenuItem_Click);
            // 
            // tabelaFacturiToolStripMenuItem
            // 
            this.tabelaFacturiToolStripMenuItem.Name = "tabelaFacturiToolStripMenuItem";
            this.tabelaFacturiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tabelaFacturiToolStripMenuItem.Text = "Tabela facturi";
            this.tabelaFacturiToolStripMenuItem.Click += new System.EventHandler(this.tabelaFacturiToolStripMenuItem_Click);
            // 
            // vieToolStripMenuItem
            // 
            this.vieToolStripMenuItem.Name = "vieToolStripMenuItem";
            this.vieToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.vieToolStripMenuItem.Text = "Edit";
            // 
            // achizitiiDataGridView
            // 
            this.achizitiiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.achizitiiDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.achizitiiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.achizitiiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.achizitiiDataGridView.Name = "achizitiiDataGridView";
            this.achizitiiDataGridView.ReadOnly = true;
            this.achizitiiDataGridView.Size = new System.Drawing.Size(1252, 343);
            this.achizitiiDataGridView.TabIndex = 3;
            this.achizitiiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.achizitiiDataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.refreshbutton);
            this.panel1.Controls.Add(this.achizitiiDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 396);
            this.panel1.TabIndex = 7;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbutton.Location = new System.Drawing.Point(1189, 361);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(75, 23);
            this.refreshbutton.TabIndex = 4;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = true;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Tabela achizitiilor";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.numeProdusComboBox);
            this.panel2.Controls.Add(this.VanzareUnitateComboBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.veziListaButton);
            this.panel2.Controls.Add(this.adaugaAchizitiaButton);
            this.panel2.Controls.Add(this.adaugaProdusButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.furnizorComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cumparareUnitateTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numarBucatiTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.depozitComboBox);
            this.panel2.Location = new System.Drawing.Point(12, 460);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1282, 63);
            this.panel2.TabIndex = 8;
            // 
            // numeProdusComboBox
            // 
            this.numeProdusComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.numeProdusComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.numeProdusComboBox.FormattingEnabled = true;
            this.numeProdusComboBox.Location = new System.Drawing.Point(12, 24);
            this.numeProdusComboBox.Name = "numeProdusComboBox";
            this.numeProdusComboBox.Size = new System.Drawing.Size(167, 21);
            this.numeProdusComboBox.TabIndex = 16;
            this.numeProdusComboBox.SelectedIndexChanged += new System.EventHandler(this.numeProdusComboBox_SelectedIndexChanged);
            // 
            // VanzareUnitateComboBox1
            // 
            this.VanzareUnitateComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VanzareUnitateComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.VanzareUnitateComboBox1.FormattingEnabled = true;
            this.VanzareUnitateComboBox1.Location = new System.Drawing.Point(394, 23);
            this.VanzareUnitateComboBox1.Name = "VanzareUnitateComboBox1";
            this.VanzareUnitateComboBox1.Size = new System.Drawing.Size(126, 21);
            this.VanzareUnitateComboBox1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pret vanzare pe unitate";
            // 
            // veziListaButton
            // 
            this.veziListaButton.Location = new System.Drawing.Point(1077, 22);
            this.veziListaButton.Name = "veziListaButton";
            this.veziListaButton.Size = new System.Drawing.Size(98, 23);
            this.veziListaButton.TabIndex = 12;
            this.veziListaButton.Text = "Editeaza lista";
            this.veziListaButton.UseVisualStyleBackColor = true;
            this.veziListaButton.Click += new System.EventHandler(this.veziListaButton_Click);
            // 
            // adaugaAchizitiaButton
            // 
            this.adaugaAchizitiaButton.Location = new System.Drawing.Point(1181, 22);
            this.adaugaAchizitiaButton.Name = "adaugaAchizitiaButton";
            this.adaugaAchizitiaButton.Size = new System.Drawing.Size(95, 23);
            this.adaugaAchizitiaButton.TabIndex = 11;
            this.adaugaAchizitiaButton.Text = "Adauga achizitia";
            this.adaugaAchizitiaButton.UseVisualStyleBackColor = true;
            this.adaugaAchizitiaButton.Click += new System.EventHandler(this.adaugaAchizitiaButton_Click);
            // 
            // adaugaProdusButton
            // 
            this.adaugaProdusButton.Location = new System.Drawing.Point(969, 22);
            this.adaugaProdusButton.Name = "adaugaProdusButton";
            this.adaugaProdusButton.Size = new System.Drawing.Size(102, 23);
            this.adaugaProdusButton.TabIndex = 10;
            this.adaugaProdusButton.Text = "Adauga Produs";
            this.adaugaProdusButton.UseVisualStyleBackColor = true;
            this.adaugaProdusButton.Click += new System.EventHandler(this.adaugaProdusButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(750, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Furnizor";
            // 
            // furnizorComboBox
            // 
            this.furnizorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.furnizorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.furnizorComboBox.FormattingEnabled = true;
            this.furnizorComboBox.Location = new System.Drawing.Point(748, 24);
            this.furnizorComboBox.Name = "furnizorComboBox";
            this.furnizorComboBox.Size = new System.Drawing.Size(215, 21);
            this.furnizorComboBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Depozit";
            // 
            // cumparareUnitateTextBox
            // 
            this.cumparareUnitateTextBox.Location = new System.Drawing.Point(259, 24);
            this.cumparareUnitateTextBox.Name = "cumparareUnitateTextBox";
            this.cumparareUnitateTextBox.Size = new System.Drawing.Size(129, 20);
            this.cumparareUnitateTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pret cumparare pe unitate";
            // 
            // numarBucatiTextBox
            // 
            this.numarBucatiTextBox.Location = new System.Drawing.Point(185, 24);
            this.numarBucatiTextBox.Name = "numarBucatiTextBox";
            this.numarBucatiTextBox.Size = new System.Drawing.Size(68, 20);
            this.numarBucatiTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numar Bucati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume produs";
            // 
            // depozitComboBox
            // 
            this.depozitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.depozitComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.depozitComboBox.FormattingEnabled = true;
            this.depozitComboBox.Location = new System.Drawing.Point(526, 24);
            this.depozitComboBox.Name = "depozitComboBox";
            this.depozitComboBox.Size = new System.Drawing.Size(216, 21);
            this.depozitComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add Achizitie";
            // 
            // AchizitiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1309, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AchizitiiForm";
            this.Text = "AchizitiiForm";
            this.Load += new System.EventHandler(this.AchizitiiForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView achizitiiDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox depozitComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cumparareUnitateTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numarBucatiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox furnizorComboBox;
        private System.Windows.Forms.Button veziListaButton;
        private System.Windows.Forms.Button adaugaAchizitiaButton;
        private System.Windows.Forms.Button adaugaProdusButton;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.ComboBox numeProdusComboBox;
        private System.Windows.Forms.ComboBox VanzareUnitateComboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depozitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achizitiiTabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depoziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaFurnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaFacturiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vieToolStripMenuItem;
    }
}