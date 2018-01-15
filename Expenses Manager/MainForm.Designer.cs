using System.Linq;

namespace Expenses_Manager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAngajati = new System.Windows.Forms.Label();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssCheltuieli = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCastiguri = new System.Windows.Forms.ToolStripStatusLabel();
            this.btAngajati = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.dataGridViewComenzi = new System.Windows.Forms.DataGridView();
            this.btComenzi = new System.Windows.Forms.Button();
            this.btAchizitii = new System.Windows.Forms.Button();
            this.btRaport = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.btDataBase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.ssMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName.Location = new System.Drawing.Point(653, 56);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "user";
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            this.tbUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tdUserName_MouseDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(760, 56);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseDown);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(772, 82);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(88, 27);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(884, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lbAngajati
            // 
            this.lbAngajati.Location = new System.Drawing.Point(0, 0);
            this.lbAngajati.Name = "lbAngajati";
            this.lbAngajati.Size = new System.Drawing.Size(100, 23);
            this.lbAngajati.TabIndex = 6;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCheltuieli,
            this.tssCastiguri});
            this.ssMain.Location = new System.Drawing.Point(0, 430);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(884, 22);
            this.ssMain.TabIndex = 5;
            // 
            // tssCheltuieli
            // 
            this.tssCheltuieli.Name = "tssCheltuieli";
            this.tssCheltuieli.Size = new System.Drawing.Size(63, 17);
            this.tssCheltuieli.Text = "Cheltuieli: ";
            // 
            // tssCastiguri
            // 
            this.tssCastiguri.Name = "tssCastiguri";
            this.tssCastiguri.Size = new System.Drawing.Size(60, 17);
            this.tssCastiguri.Text = "Castiguri: ";
            // 
            // btAngajati
            // 
            this.btAngajati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAngajati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAngajati.Location = new System.Drawing.Point(12, 399);
            this.btAngajati.Name = "btAngajati";
            this.btAngajati.Size = new System.Drawing.Size(88, 27);
            this.btAngajati.TabIndex = 7;
            this.btAngajati.Text = "Angajati";
            this.btAngajati.UseVisualStyleBackColor = true;
            this.btAngajati.Click += new System.EventHandler(this.btAngajati_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(662, 56);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(122, 20);
            this.lbLogin.TabIndex = 8;
            this.lbLogin.Text = "Nume utilizator: ";
            this.lbLogin.Visible = false;
            // 
            // dataGridViewComenzi
            // 
            this.dataGridViewComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComenzi.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewComenzi.Name = "dataGridViewComenzi";
            this.dataGridViewComenzi.Size = new System.Drawing.Size(620, 337);
            this.dataGridViewComenzi.TabIndex = 9;
            // 
            // btComenzi
            // 
            this.btComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComenzi.Location = new System.Drawing.Point(106, 399);
            this.btComenzi.Name = "btComenzi";
            this.btComenzi.Size = new System.Drawing.Size(88, 27);
            this.btComenzi.TabIndex = 10;
            this.btComenzi.Text = "Comenzi";
            this.btComenzi.UseVisualStyleBackColor = true;
            // 
            // btAchizitii
            // 
            this.btAchizitii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAchizitii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAchizitii.Location = new System.Drawing.Point(200, 399);
            this.btAchizitii.Name = "btAchizitii";
            this.btAchizitii.Size = new System.Drawing.Size(88, 27);
            this.btAchizitii.TabIndex = 11;
            this.btAchizitii.Text = "Achizitii";
            this.btAchizitii.UseVisualStyleBackColor = true;
            this.btAchizitii.Click += new System.EventHandler(this.btAchizitii_Click);
            // 
            // btRaport
            // 
            this.btRaport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRaport.Location = new System.Drawing.Point(665, 160);
            this.btRaport.Name = "btRaport";
            this.btRaport.Size = new System.Drawing.Size(88, 27);
            this.btRaport.TabIndex = 15;
            this.btRaport.Text = "Raport";
            this.btRaport.UseVisualStyleBackColor = true;
            this.btRaport.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(746, 437);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 16;
            this.lbDate.Text = "Date";
            // 
            // btDataBase
            // 
            this.btDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataBase.Location = new System.Drawing.Point(760, 160);
            this.btDataBase.Name = "btDataBase";
            this.btDataBase.Size = new System.Drawing.Size(88, 27);
            this.btDataBase.TabIndex = 17;
            this.btDataBase.Text = "DataBase";
            this.btDataBase.UseVisualStyleBackColor = true;
            this.btDataBase.Click += new System.EventHandler(this.btDataBase_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 452);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDataBase);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btRaport);
            this.Controls.Add(this.btAchizitii);
            this.Controls.Add(this.btComenzi);
            this.Controls.Add(this.dataGridViewComenzi);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btAngajati);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.lbAngajati);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComenzi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Label lbAngajati;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Button btAngajati;
        private System.Windows.Forms.ToolStripStatusLabel tssCheltuieli;
        private System.Windows.Forms.ToolStripStatusLabel tssCastiguri;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.DataGridView dataGridViewComenzi;
        private System.Windows.Forms.Button btComenzi;
        private System.Windows.Forms.Button btAchizitii;
        private System.Windows.Forms.Button btRaport;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btDataBase;
        private System.Windows.Forms.Button button1;
    }
}