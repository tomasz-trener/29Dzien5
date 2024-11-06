namespace P01NoweOkna
{
    partial class FrmNoweOkno
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
            this.txtFrmNoweOknoWiadomosc = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.btnOdbierz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrmNoweOknoWiadomosc
            // 
            this.txtFrmNoweOknoWiadomosc.Location = new System.Drawing.Point(12, 12);
            this.txtFrmNoweOknoWiadomosc.Name = "txtFrmNoweOknoWiadomosc";
            this.txtFrmNoweOknoWiadomosc.Size = new System.Drawing.Size(156, 20);
            this.txtFrmNoweOknoWiadomosc.TabIndex = 0;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(12, 38);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 1;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // btnOdbierz
            // 
            this.btnOdbierz.Location = new System.Drawing.Point(93, 38);
            this.btnOdbierz.Name = "btnOdbierz";
            this.btnOdbierz.Size = new System.Drawing.Size(75, 23);
            this.btnOdbierz.TabIndex = 2;
            this.btnOdbierz.Text = "Odbierz";
            this.btnOdbierz.UseVisualStyleBackColor = true;
            this.btnOdbierz.Click += new System.EventHandler(this.btnOdbierz_Click);
            // 
            // FrmNoweOkno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 80);
            this.Controls.Add(this.btnOdbierz);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtFrmNoweOknoWiadomosc);
            this.Name = "FrmNoweOkno";
            this.Text = "FrmNoweOkno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrmNoweOknoWiadomosc;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.Button btnOdbierz;
    }
}