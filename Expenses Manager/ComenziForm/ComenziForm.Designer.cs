namespace Expenses_Manager.ComenziForm
{
    partial class ComenziForm
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
            this.GridViewComenzi = new System.Windows.Forms.DataGridView();
            this.GridViewDetalii = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.groupFilters = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBoxCheap = new System.Windows.Forms.TextBox();
            this.labelCheapER = new System.Windows.Forms.Label();
            this.textBoxExpensive = new System.Windows.Forms.TextBox();
            this.labelExpensivER = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelLaterThan = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelEarlierThan = new System.Windows.Forms.Label();
            this.comboBoxFStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxFDestinatar = new System.Windows.Forms.ComboBox();
            this.comboBoxFAngajat = new System.Windows.Forms.ComboBox();
            this.comboBoxFFactura = new System.Windows.Forms.ComboBox();
            this.labelDestinatar = new System.Windows.Forms.Label();
            this.labelAngajat = new System.Windows.Forms.Label();
            this.labelNumarFactura = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupDetailsPart = new System.Windows.Forms.GroupBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxSubtotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCantitate = new System.Windows.Forms.TextBox();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.comboBoxProduse = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.groupAddOrder = new System.Windows.Forms.GroupBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.labelEstDate = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statuslabel_Comanda_ID = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonResetFilters = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComenzi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDetalii)).BeginInit();
            this.groupFilters.SuspendLayout();
            this.groupDetailsPart.SuspendLayout();
            this.groupAddOrder.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewComenzi
            // 
            this.GridViewComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GridViewComenzi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridViewComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewComenzi.Location = new System.Drawing.Point(12, 47);
            this.GridViewComenzi.Name = "GridViewComenzi";
            this.GridViewComenzi.Size = new System.Drawing.Size(866, 344);
            this.GridViewComenzi.TabIndex = 0;
            this.GridViewComenzi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewComenzi_CellContentClick);
            this.GridViewComenzi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewComenzi_RowEnter);
            this.GridViewComenzi.SelectionChanged += new System.EventHandler(this.GridViewComenzi_SelectionChanged);
            // 
            // GridViewDetalii
            // 
            this.GridViewDetalii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewDetalii.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GridViewDetalii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDetalii.Location = new System.Drawing.Point(884, 47);
            this.GridViewDetalii.Name = "GridViewDetalii";
            this.GridViewDetalii.Size = new System.Drawing.Size(356, 344);
            this.GridViewDetalii.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comenzi";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(881, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Detalii";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TextBoxSearch.Location = new System.Drawing.Point(12, 397);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(238, 20);
            this.TextBoxSearch.TabIndex = 4;
            this.TextBoxSearch.Text = "Introduceti Numarul Comenzii";
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            this.TextBoxSearch.Enter += new System.EventHandler(this.TextBoxSearch_Enter);
            // 
            // groupFilters
            // 
            this.groupFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupFilters.Controls.Add(this.checkBox4);
            this.groupFilters.Controls.Add(this.checkBox3);
            this.groupFilters.Controls.Add(this.textBoxCheap);
            this.groupFilters.Controls.Add(this.labelCheapER);
            this.groupFilters.Controls.Add(this.textBoxExpensive);
            this.groupFilters.Controls.Add(this.labelExpensivER);
            this.groupFilters.Controls.Add(this.checkBox2);
            this.groupFilters.Controls.Add(this.dateTimePicker2);
            this.groupFilters.Controls.Add(this.checkBox1);
            this.groupFilters.Controls.Add(this.labelLaterThan);
            this.groupFilters.Controls.Add(this.dateTimePicker1);
            this.groupFilters.Controls.Add(this.labelEarlierThan);
            this.groupFilters.Controls.Add(this.comboBoxFStatus);
            this.groupFilters.Controls.Add(this.labelStatus);
            this.groupFilters.Controls.Add(this.comboBoxFDestinatar);
            this.groupFilters.Controls.Add(this.comboBoxFAngajat);
            this.groupFilters.Controls.Add(this.comboBoxFFactura);
            this.groupFilters.Controls.Add(this.labelDestinatar);
            this.groupFilters.Controls.Add(this.labelAngajat);
            this.groupFilters.Controls.Add(this.labelNumarFactura);
            this.groupFilters.Location = new System.Drawing.Point(337, 397);
            this.groupFilters.Name = "groupFilters";
            this.groupFilters.Size = new System.Drawing.Size(541, 139);
            this.groupFilters.TabIndex = 5;
            this.groupFilters.TabStop = false;
            this.groupFilters.Text = "Filters";
            this.groupFilters.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(511, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 19;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(511, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBoxCheap
            // 
            this.textBoxCheap.Location = new System.Drawing.Point(305, 103);
            this.textBoxCheap.Name = "textBoxCheap";
            this.textBoxCheap.Size = new System.Drawing.Size(200, 20);
            this.textBoxCheap.TabIndex = 17;
            this.textBoxCheap.TextChanged += new System.EventHandler(this.textBoxCheap_TextChanged);
            // 
            // labelCheapER
            // 
            this.labelCheapER.AutoSize = true;
            this.labelCheapER.Location = new System.Drawing.Point(221, 106);
            this.labelCheapER.Name = "labelCheapER";
            this.labelCheapER.Size = new System.Drawing.Size(64, 13);
            this.labelCheapER.TabIndex = 16;
            this.labelCheapER.Text = "Mai ieftin de";
            // 
            // textBoxExpensive
            // 
            this.textBoxExpensive.Location = new System.Drawing.Point(305, 76);
            this.textBoxExpensive.Name = "textBoxExpensive";
            this.textBoxExpensive.Size = new System.Drawing.Size(200, 20);
            this.textBoxExpensive.TabIndex = 15;
            this.textBoxExpensive.TextChanged += new System.EventHandler(this.textBoxExpensive_TextChanged);
            // 
            // labelExpensivER
            // 
            this.labelExpensivER.AutoSize = true;
            this.labelExpensivER.Location = new System.Drawing.Point(221, 79);
            this.labelExpensivER.Name = "labelExpensivER";
            this.labelExpensivER.Size = new System.Drawing.Size(73, 13);
            this.labelExpensivER.TabIndex = 14;
            this.labelExpensivER.Text = "Mai scump de";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(511, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(305, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            this.dateTimePicker2.TabIndexChanged += new System.EventHandler(this.dateTimePicker2_TabIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(511, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelLaterThan
            // 
            this.labelLaterThan.AutoSize = true;
            this.labelLaterThan.Location = new System.Drawing.Point(221, 51);
            this.labelLaterThan.Name = "labelLaterThan";
            this.labelLaterThan.Size = new System.Drawing.Size(72, 13);
            this.labelLaterThan.TabIndex = 10;
            this.labelLaterThan.Text = "Dupa data de";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(305, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelEarlierThan
            // 
            this.labelEarlierThan.AutoSize = true;
            this.labelEarlierThan.Location = new System.Drawing.Point(221, 23);
            this.labelEarlierThan.Name = "labelEarlierThan";
            this.labelEarlierThan.Size = new System.Drawing.Size(78, 13);
            this.labelEarlierThan.TabIndex = 8;
            this.labelEarlierThan.Text = "Inainte de data";
            // 
            // comboBoxFStatus
            // 
            this.comboBoxFStatus.FormattingEnabled = true;
            this.comboBoxFStatus.Location = new System.Drawing.Point(69, 103);
            this.comboBoxFStatus.Name = "comboBoxFStatus";
            this.comboBoxFStatus.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFStatus.TabIndex = 7;
            this.comboBoxFStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxFStatus_SelectedIndexChanged);
            this.comboBoxFStatus.TextChanged += new System.EventHandler(this.comboBoxFStatus_TextChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(8, 106);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxFDestinatar
            // 
            this.comboBoxFDestinatar.FormattingEnabled = true;
            this.comboBoxFDestinatar.Location = new System.Drawing.Point(69, 76);
            this.comboBoxFDestinatar.Name = "comboBoxFDestinatar";
            this.comboBoxFDestinatar.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFDestinatar.TabIndex = 5;
            this.comboBoxFDestinatar.TextChanged += new System.EventHandler(this.comboBoxFDestinatar_TextChanged);
            // 
            // comboBoxFAngajat
            // 
            this.comboBoxFAngajat.FormattingEnabled = true;
            this.comboBoxFAngajat.Location = new System.Drawing.Point(69, 48);
            this.comboBoxFAngajat.Name = "comboBoxFAngajat";
            this.comboBoxFAngajat.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFAngajat.TabIndex = 4;
            this.comboBoxFAngajat.TextChanged += new System.EventHandler(this.comboBoxFAngajat_TextChanged);
            // 
            // comboBoxFFactura
            // 
            this.comboBoxFFactura.FormattingEnabled = true;
            this.comboBoxFFactura.Location = new System.Drawing.Point(69, 20);
            this.comboBoxFFactura.Name = "comboBoxFFactura";
            this.comboBoxFFactura.Size = new System.Drawing.Size(146, 21);
            this.comboBoxFFactura.TabIndex = 3;
            this.comboBoxFFactura.TextUpdate += new System.EventHandler(this.comboBoxFFactura_TextUpdate);
            this.comboBoxFFactura.TextChanged += new System.EventHandler(this.comboBoxFFactura_TextChanged);
            // 
            // labelDestinatar
            // 
            this.labelDestinatar.AutoSize = true;
            this.labelDestinatar.Location = new System.Drawing.Point(8, 79);
            this.labelDestinatar.Name = "labelDestinatar";
            this.labelDestinatar.Size = new System.Drawing.Size(55, 13);
            this.labelDestinatar.TabIndex = 2;
            this.labelDestinatar.Text = "Destinatar";
            // 
            // labelAngajat
            // 
            this.labelAngajat.AutoSize = true;
            this.labelAngajat.Location = new System.Drawing.Point(6, 51);
            this.labelAngajat.Name = "labelAngajat";
            this.labelAngajat.Size = new System.Drawing.Size(43, 13);
            this.labelAngajat.TabIndex = 1;
            this.labelAngajat.Text = "Angajat";
            // 
            // labelNumarFactura
            // 
            this.labelNumarFactura.AutoSize = true;
            this.labelNumarFactura.Location = new System.Drawing.Point(6, 23);
            this.labelNumarFactura.Name = "labelNumarFactura";
            this.labelNumarFactura.Size = new System.Drawing.Size(43, 13);
            this.labelNumarFactura.TabIndex = 0;
            this.labelNumarFactura.Text = "Factura";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(256, 493);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpdate.Location = new System.Drawing.Point(256, 406);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupDetailsPart
            // 
            this.groupDetailsPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupDetailsPart.Controls.Add(this.buttonAddPart);
            this.groupDetailsPart.Controls.Add(this.textBoxTotal);
            this.groupDetailsPart.Controls.Add(this.textBoxSubtotal);
            this.groupDetailsPart.Controls.Add(this.labelTotal);
            this.groupDetailsPart.Controls.Add(this.textBoxCantitate);
            this.groupDetailsPart.Controls.Add(this.labelSubtotal);
            this.groupDetailsPart.Controls.Add(this.labelCantitate);
            this.groupDetailsPart.Controls.Add(this.comboBoxProduse);
            this.groupDetailsPart.Controls.Add(this.labelProduct);
            this.groupDetailsPart.Location = new System.Drawing.Point(884, 397);
            this.groupDetailsPart.Name = "groupDetailsPart";
            this.groupDetailsPart.Size = new System.Drawing.Size(356, 139);
            this.groupDetailsPart.TabIndex = 10;
            this.groupDetailsPart.TabStop = false;
            this.groupDetailsPart.Text = "Add Order Part";
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(252, 99);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(98, 23);
            this.buttonAddPart.TabIndex = 8;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(62, 102);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(184, 20);
            this.textBoxTotal.TabIndex = 7;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSubtotal
            // 
            this.textBoxSubtotal.Enabled = false;
            this.textBoxSubtotal.Location = new System.Drawing.Point(62, 76);
            this.textBoxSubtotal.Name = "textBoxSubtotal";
            this.textBoxSubtotal.Size = new System.Drawing.Size(184, 20);
            this.textBoxSubtotal.TabIndex = 6;
            this.textBoxSubtotal.Text = "0";
            this.textBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(7, 106);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // textBoxCantitate
            // 
            this.textBoxCantitate.Location = new System.Drawing.Point(62, 48);
            this.textBoxCantitate.Name = "textBoxCantitate";
            this.textBoxCantitate.Size = new System.Drawing.Size(184, 20);
            this.textBoxCantitate.TabIndex = 4;
            this.textBoxCantitate.TextChanged += new System.EventHandler(this.textBoxCantitate_TextChanged);
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Location = new System.Drawing.Point(7, 79);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(46, 13);
            this.labelSubtotal.TabIndex = 3;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelCantitate
            // 
            this.labelCantitate.AutoSize = true;
            this.labelCantitate.Location = new System.Drawing.Point(7, 51);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(49, 13);
            this.labelCantitate.TabIndex = 2;
            this.labelCantitate.Text = "Cantitate";
            // 
            // comboBoxProduse
            // 
            this.comboBoxProduse.FormattingEnabled = true;
            this.comboBoxProduse.Location = new System.Drawing.Point(62, 19);
            this.comboBoxProduse.Name = "comboBoxProduse";
            this.comboBoxProduse.Size = new System.Drawing.Size(184, 21);
            this.comboBoxProduse.TabIndex = 1;
            this.comboBoxProduse.TextChanged += new System.EventHandler(this.comboBoxProduse_TextChanged);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(7, 23);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(40, 13);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Produs";
            // 
            // groupAddOrder
            // 
            this.groupAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupAddOrder.Controls.Add(this.dateTimePicker3);
            this.groupAddOrder.Controls.Add(this.labelEstDate);
            this.groupAddOrder.Controls.Add(this.comboBoxClient);
            this.groupAddOrder.Controls.Add(this.labelClient);
            this.groupAddOrder.Location = new System.Drawing.Point(12, 424);
            this.groupAddOrder.Name = "groupAddOrder";
            this.groupAddOrder.Size = new System.Drawing.Size(238, 112);
            this.groupAddOrder.TabIndex = 12;
            this.groupAddOrder.TabStop = false;
            this.groupAddOrder.Text = "Add Order";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 79);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker3.TabIndex = 3;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // labelEstDate
            // 
            this.labelEstDate.AutoSize = true;
            this.labelEstDate.Location = new System.Drawing.Point(6, 61);
            this.labelEstDate.Name = "labelEstDate";
            this.labelEstDate.Size = new System.Drawing.Size(73, 13);
            this.labelEstDate.TabIndex = 2;
            this.labelEstDate.Text = "Data Estimata";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(6, 37);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(226, 21);
            this.comboBoxClient.TabIndex = 1;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(3, 21);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(33, 13);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Client";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel_Comanda_ID});
            this.statusStrip.Location = new System.Drawing.Point(0, 526);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1252, 22);
            this.statusStrip.TabIndex = 13;
            this.statusStrip.Text = "Status Bar";
            // 
            // statuslabel_Comanda_ID
            // 
            this.statuslabel_Comanda_ID.Name = "statuslabel_Comanda_ID";
            this.statuslabel_Comanda_ID.Size = new System.Drawing.Size(79, 17);
            this.statuslabel_Comanda_ID.Text = "ID Comanda: ";
            this.statuslabel_Comanda_ID.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // buttonResetFilters
            // 
            this.buttonResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonResetFilters.Location = new System.Drawing.Point(256, 464);
            this.buttonResetFilters.Name = "buttonResetFilters";
            this.buttonResetFilters.Size = new System.Drawing.Size(75, 23);
            this.buttonResetFilters.TabIndex = 15;
            this.buttonResetFilters.Text = "Reset Filters";
            this.buttonResetFilters.UseVisualStyleBackColor = true;
            this.buttonResetFilters.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRefresh.Location = new System.Drawing.Point(256, 435);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 17;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ComenziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 548);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonResetFilters);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupAddOrder);
            this.Controls.Add(this.groupDetailsPart);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupFilters);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewDetalii);
            this.Controls.Add(this.GridViewComenzi);
            this.Name = "ComenziForm";
            this.Text = "ComenziForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewComenzi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDetalii)).EndInit();
            this.groupFilters.ResumeLayout(false);
            this.groupFilters.PerformLayout();
            this.groupDetailsPart.ResumeLayout(false);
            this.groupDetailsPart.PerformLayout();
            this.groupAddOrder.ResumeLayout(false);
            this.groupAddOrder.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewComenzi;
        private System.Windows.Forms.DataGridView GridViewDetalii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.GroupBox groupFilters;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBoxCheap;
        private System.Windows.Forms.Label labelCheapER;
        private System.Windows.Forms.TextBox textBoxExpensive;
        private System.Windows.Forms.Label labelExpensivER;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelLaterThan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelEarlierThan;
        private System.Windows.Forms.ComboBox comboBoxFStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxFDestinatar;
        private System.Windows.Forms.ComboBox comboBoxFAngajat;
        private System.Windows.Forms.ComboBox comboBoxFFactura;
        private System.Windows.Forms.Label labelDestinatar;
        private System.Windows.Forms.Label labelAngajat;
        private System.Windows.Forms.Label labelNumarFactura;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupDetailsPart;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxCantitate;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.ComboBox comboBoxProduse;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxSubtotal;
        private System.Windows.Forms.GroupBox groupAddOrder;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label labelEstDate;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel_Comanda_ID;
        private System.Windows.Forms.Button buttonResetFilters;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefresh;
    }
}