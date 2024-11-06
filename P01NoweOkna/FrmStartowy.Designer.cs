namespace P01NoweOkna
{
    partial class FrmStartowy
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
            this.btnNoweOkno = new System.Windows.Forms.Button();
            this.txtFormularzStartowyWiadomosc = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.btnOdbierz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoweOkno
            // 
            this.btnNoweOkno.Location = new System.Drawing.Point(28, 12);
            this.btnNoweOkno.Name = "btnNoweOkno";
            this.btnNoweOkno.Size = new System.Drawing.Size(157, 54);
            this.btnNoweOkno.TabIndex = 0;
            this.btnNoweOkno.Text = "Nowe okno";
            this.btnNoweOkno.UseVisualStyleBackColor = true;
            this.btnNoweOkno.Click += new System.EventHandler(this.btnNoweOkno_Click);
            // 
            // txtFormularzStartowyWiadomosc
            // 
            this.txtFormularzStartowyWiadomosc.Location = new System.Drawing.Point(29, 77);
            this.txtFormularzStartowyWiadomosc.Name = "txtFormularzStartowyWiadomosc";
            this.txtFormularzStartowyWiadomosc.Size = new System.Drawing.Size(156, 20);
            this.txtFormularzStartowyWiadomosc.TabIndex = 1;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(29, 104);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 2;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // btnOdbierz
            // 
            this.btnOdbierz.Location = new System.Drawing.Point(110, 104);
            this.btnOdbierz.Name = "btnOdbierz";
            this.btnOdbierz.Size = new System.Drawing.Size(75, 23);
            this.btnOdbierz.TabIndex = 4;
            this.btnOdbierz.Text = "Odbierz";
            this.btnOdbierz.UseVisualStyleBackColor = true;
            this.btnOdbierz.Click += new System.EventHandler(this.btnOdbierz_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 145);
            this.Controls.Add(this.btnOdbierz);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtFormularzStartowyWiadomosc);
            this.Controls.Add(this.btnNoweOkno);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNoweOkno;
        private System.Windows.Forms.TextBox txtFormularzStartowyWiadomosc;
        private System.Windows.Forms.Button btnWyslij;
        private System.Windows.Forms.Button btnOdbierz;
    }
}

