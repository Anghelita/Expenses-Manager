namespace Expenses_Manager
{
    partial class CreareContForm
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
            this.lbUtilizator = new System.Windows.Forms.Label();
            this.lbParola = new System.Windows.Forms.Label();
            this.tbUtilizator = new System.Windows.Forms.TextBox();
            this.tbParola = new System.Windows.Forms.TextBox();
            this.btInregistreaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUtilizator
            // 
            this.lbUtilizator.AutoSize = true;
            this.lbUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtilizator.Location = new System.Drawing.Point(13, 39);
            this.lbUtilizator.Name = "lbUtilizator";
            this.lbUtilizator.Size = new System.Drawing.Size(93, 15);
            this.lbUtilizator.TabIndex = 0;
            this.lbUtilizator.Text = "Nume utilizator:";
            // 
            // lbParola
            // 
            this.lbParola.AutoSize = true;
            this.lbParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParola.Location = new System.Drawing.Point(57, 65);
            this.lbParola.Name = "lbParola";
            this.lbParola.Size = new System.Drawing.Size(49, 15);
            this.lbParola.TabIndex = 1;
            this.lbParola.Text = "Parola: ";
            // 
            // tbUtilizator
            // 
            this.tbUtilizator.Location = new System.Drawing.Point(112, 38);
            this.tbUtilizator.Name = "tbUtilizator";
            this.tbUtilizator.Size = new System.Drawing.Size(141, 20);
            this.tbUtilizator.TabIndex = 2;
            // 
            // tbParola
            // 
            this.tbParola.Location = new System.Drawing.Point(112, 64);
            this.tbParola.Name = "tbParola";
            this.tbParola.Size = new System.Drawing.Size(141, 20);
            this.tbParola.TabIndex = 3;
            this.tbParola.UseSystemPasswordChar = true;
            // 
            // btInregistreaza
            // 
            this.btInregistreaza.Location = new System.Drawing.Point(171, 90);
            this.btInregistreaza.Name = "btInregistreaza";
            this.btInregistreaza.Size = new System.Drawing.Size(82, 23);
            this.btInregistreaza.TabIndex = 4;
            this.btInregistreaza.Text = "Inregistreaza";
            this.btInregistreaza.UseVisualStyleBackColor = true;
            // 
            // CreareContForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 159);
            this.Controls.Add(this.btInregistreaza);
            this.Controls.Add(this.tbParola);
            this.Controls.Add(this.tbUtilizator);
            this.Controls.Add(this.lbParola);
            this.Controls.Add(this.lbUtilizator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreareContForm";
            this.Text = "CreareContForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUtilizator;
        private System.Windows.Forms.Label lbParola;
        private System.Windows.Forms.TextBox tbUtilizator;
        private System.Windows.Forms.TextBox tbParola;
        private System.Windows.Forms.Button btInregistreaza;
    }
}