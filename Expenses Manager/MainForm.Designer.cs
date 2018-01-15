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
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tssCheltuieli = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssCastiguri = new System.Windows.Forms.ToolStripStatusLabel();
            this.btAngajati = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.btComenzi = new System.Windows.Forms.Button();
            this.btAchizitii = new System.Windows.Forms.Button();
            this.btRaport = new System.Windows.Forms.Button();
            this.lbDate = new System.Windows.Forms.Label();
            this.btDataBase = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbUserName.Location = new System.Drawing.Point(32, 47);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Text = "user";
            this.tbUserName.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            this.tbUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tdUserName_MouseDown);
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbPassword.Location = new System.Drawing.Point(138, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "password";
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseDown);
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(32, 73);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(100, 27);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCheltuieli,
            this.tssCastiguri});
            this.ssMain.Location = new System.Drawing.Point(0, 381);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(277, 22);
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
            this.btAngajati.Location = new System.Drawing.Point(87, 296);
            this.btAngajati.Name = "btAngajati";
            this.btAngajati.Size = new System.Drawing.Size(88, 27);
            this.btAngajati.TabIndex = 7;
            this.btAngajati.Text = "Angajati";
            this.btAngajati.UseVisualStyleBackColor = true;
            this.btAngajati.Click += new System.EventHandler(this.btAngajati_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(28, 47);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(122, 20);
            this.lbLogin.TabIndex = 8;
            this.lbLogin.Text = "Nume utilizator: ";
            this.lbLogin.Visible = false;
            // 
            // btComenzi
            // 
            this.btComenzi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btComenzi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btComenzi.Location = new System.Drawing.Point(87, 230);
            this.btComenzi.Name = "btComenzi";
            this.btComenzi.Size = new System.Drawing.Size(88, 27);
            this.btComenzi.TabIndex = 10;
            this.btComenzi.Text = "Comenzi";
            this.btComenzi.UseVisualStyleBackColor = true;
            this.btComenzi.Click += new System.EventHandler(this.btComenzi_Click);
            // 
            // btAchizitii
            // 
            this.btAchizitii.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAchizitii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAchizitii.Location = new System.Drawing.Point(87, 263);
            this.btAchizitii.Name = "btAchizitii";
            this.btAchizitii.Size = new System.Drawing.Size(88, 27);
            this.btAchizitii.TabIndex = 11;
            this.btAchizitii.Text = "Achizitii";
            this.btAchizitii.UseVisualStyleBackColor = true;
            this.btAchizitii.Click += new System.EventHandler(this.btAchizitii_Click);
            // 
            // btRaport
            // 
            this.btRaport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRaport.Location = new System.Drawing.Point(30, 151);
            this.btRaport.Name = "btRaport";
            this.btRaport.Size = new System.Drawing.Size(100, 27);
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
            this.btDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDataBase.Location = new System.Drawing.Point(136, 151);
            this.btDataBase.Name = "btDataBase";
            this.btDataBase.Size = new System.Drawing.Size(100, 27);
            this.btDataBase.TabIndex = 17;
            this.btDataBase.Text = "DataBase";
            this.btDataBase.UseVisualStyleBackColor = true;
            this.btDataBase.Click += new System.EventHandler(this.btDataBase_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(32, 74);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(100, 27);
            this.btLogout.TabIndex = 18;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Visible = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 403);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btDataBase);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.btRaport);
            this.Controls.Add(this.btAchizitii);
            this.Controls.Add(this.btComenzi);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btAngajati);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Button btAngajati;
        private System.Windows.Forms.ToolStripStatusLabel tssCheltuieli;
        private System.Windows.Forms.ToolStripStatusLabel tssCastiguri;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btComenzi;
        private System.Windows.Forms.Button btAchizitii;
        private System.Windows.Forms.Button btRaport;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Button btDataBase;
        private System.Windows.Forms.Button btLogout;
    }
}