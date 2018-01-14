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
            this.achizitiiDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.veziListaButton = new System.Windows.Forms.Button();
            this.adaugaAchizitiaButton = new System.Windows.Forms.Button();
            this.adaugaProdusButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.furnizorComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pretUnitatetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numarBucatiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeProdusTextBox = new System.Windows.Forms.TextBox();
            this.depozitComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 520);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1162, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // achizitiiDataGridView
            // 
            this.achizitiiDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.achizitiiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.achizitiiDataGridView.Location = new System.Drawing.Point(12, 12);
            this.achizitiiDataGridView.Name = "achizitiiDataGridView";
            this.achizitiiDataGridView.ReadOnly = true;
            this.achizitiiDataGridView.Size = new System.Drawing.Size(1123, 339);
            this.achizitiiDataGridView.TabIndex = 3;
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
            this.panel1.Size = new System.Drawing.Size(1138, 386);
            this.panel1.TabIndex = 7;
            // 
            // refreshbutton
            // 
            this.refreshbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshbutton.Location = new System.Drawing.Point(1060, 357);
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
            this.panel2.Controls.Add(this.veziListaButton);
            this.panel2.Controls.Add(this.adaugaAchizitiaButton);
            this.panel2.Controls.Add(this.adaugaProdusButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.furnizorComboBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pretUnitatetextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.numarBucatiTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.numeProdusTextBox);
            this.panel2.Controls.Add(this.depozitComboBox);
            this.panel2.Location = new System.Drawing.Point(12, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 63);
            this.panel2.TabIndex = 8;
            // 
            // veziListaButton
            // 
            this.veziListaButton.Location = new System.Drawing.Point(936, 24);
            this.veziListaButton.Name = "veziListaButton";
            this.veziListaButton.Size = new System.Drawing.Size(98, 23);
            this.veziListaButton.TabIndex = 12;
            this.veziListaButton.Text = "Editeaza lista";
            this.veziListaButton.UseVisualStyleBackColor = true;
            this.veziListaButton.Click += new System.EventHandler(this.veziListaButton_Click);
            // 
            // adaugaAchizitiaButton
            // 
            this.adaugaAchizitiaButton.Location = new System.Drawing.Point(1040, 24);
            this.adaugaAchizitiaButton.Name = "adaugaAchizitiaButton";
            this.adaugaAchizitiaButton.Size = new System.Drawing.Size(95, 23);
            this.adaugaAchizitiaButton.TabIndex = 11;
            this.adaugaAchizitiaButton.Text = "Adauga achizitia";
            this.adaugaAchizitiaButton.UseVisualStyleBackColor = true;
            this.adaugaAchizitiaButton.Click += new System.EventHandler(this.adaugaAchizitiaButton_Click);
            // 
            // adaugaProdusButton
            // 
            this.adaugaProdusButton.Location = new System.Drawing.Point(828, 24);
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
            this.label7.Location = new System.Drawing.Point(382, 8);
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
            this.furnizorComboBox.Location = new System.Drawing.Point(385, 24);
            this.furnizorComboBox.Name = "furnizorComboBox";
            this.furnizorComboBox.Size = new System.Drawing.Size(215, 21);
            this.furnizorComboBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Depozit";
            // 
            // pretUnitatetextBox
            // 
            this.pretUnitatetextBox.Location = new System.Drawing.Point(296, 24);
            this.pretUnitatetextBox.Name = "pretUnitatetextBox";
            this.pretUnitatetextBox.Size = new System.Drawing.Size(83, 20);
            this.pretUnitatetextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pret Unitate";
            // 
            // numarBucatiTextBox
            // 
            this.numarBucatiTextBox.Location = new System.Drawing.Point(222, 24);
            this.numarBucatiTextBox.Name = "numarBucatiTextBox";
            this.numarBucatiTextBox.Size = new System.Drawing.Size(68, 20);
            this.numarBucatiTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numar Bucati";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume produs";
            // 
            // numeProdusTextBox
            // 
            this.numeProdusTextBox.Location = new System.Drawing.Point(12, 24);
            this.numeProdusTextBox.Name = "numeProdusTextBox";
            this.numeProdusTextBox.Size = new System.Drawing.Size(204, 20);
            this.numeProdusTextBox.TabIndex = 1;
            // 
            // depozitComboBox
            // 
            this.depozitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.depozitComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.depozitComboBox.FormattingEnabled = true;
            this.depozitComboBox.Location = new System.Drawing.Point(606, 24);
            this.depozitComboBox.Name = "depozitComboBox";
            this.depozitComboBox.Size = new System.Drawing.Size(216, 21);
            this.depozitComboBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quick Add";
            // 
            // AchizitiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1162, 542);
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
        private System.Windows.Forms.TextBox numeProdusTextBox;
        private System.Windows.Forms.ComboBox depozitComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pretUnitatetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numarBucatiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox furnizorComboBox;
        private System.Windows.Forms.Button veziListaButton;
        private System.Windows.Forms.Button adaugaAchizitiaButton;
        private System.Windows.Forms.Button adaugaProdusButton;
        private System.Windows.Forms.Button refreshbutton;
    }
}