namespace Expenses_Manager
{
    partial class PrimaInputForm
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
            this.tbPrima = new System.Windows.Forms.TextBox();
            this.lbDescriere = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPrima
            // 
            this.tbPrima.Location = new System.Drawing.Point(57, 40);
            this.tbPrima.Name = "tbPrima";
            this.tbPrima.Size = new System.Drawing.Size(156, 20);
            this.tbPrima.TabIndex = 0;
            // 
            // lbDescriere
            // 
            this.lbDescriere.AutoSize = true;
            this.lbDescriere.Location = new System.Drawing.Point(54, 24);
            this.lbDescriere.Name = "lbDescriere";
            this.lbDescriere.Size = new System.Drawing.Size(164, 13);
            this.lbDescriere.TabIndex = 1;
            this.lbDescriere.Text = "Va rugam introduceti prima dorita:";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(97, 66);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // PrimaInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 102);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.lbDescriere);
            this.Controls.Add(this.tbPrima);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrimaInputForm";
            this.Text = "PrimaInputForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPrima;
        private System.Windows.Forms.Label lbDescriere;
        private System.Windows.Forms.Button btOK;
    }
}