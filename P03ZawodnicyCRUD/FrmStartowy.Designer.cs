namespace P03ZawodnicyCRUD
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnTemperatuara = new System.Windows.Forms.Button();
            this.lblRaport = new System.Windows.Forms.Label();
            this.cbKraje = new System.Windows.Forms.ComboBox();
            this.lblRaportWzrost = new System.Windows.Forms.Label();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 39);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(164, 147);
            this.lbDane.TabIndex = 0;
            // 
            // btnTemperatuara
            // 
            this.btnTemperatuara.Location = new System.Drawing.Point(12, 231);
            this.btnTemperatuara.Name = "btnTemperatuara";
            this.btnTemperatuara.Size = new System.Drawing.Size(164, 23);
            this.btnTemperatuara.TabIndex = 2;
            this.btnTemperatuara.Text = "Podaj temperature";
            this.btnTemperatuara.UseVisualStyleBackColor = true;
            this.btnTemperatuara.Click += new System.EventHandler(this.btnTemperatuara_Click);
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(13, 271);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 3;
            this.lblRaport.Text = "label1";
            // 
            // cbKraje
            // 
            this.cbKraje.FormattingEnabled = true;
            this.cbKraje.Location = new System.Drawing.Point(12, 13);
            this.cbKraje.Name = "cbKraje";
            this.cbKraje.Size = new System.Drawing.Size(164, 21);
            this.cbKraje.TabIndex = 4;
            this.cbKraje.SelectedIndexChanged += new System.EventHandler(this.cbKraje_SelectedIndexChanged);
            // 
            // lblRaportWzrost
            // 
            this.lblRaportWzrost.AutoSize = true;
            this.lblRaportWzrost.Location = new System.Drawing.Point(12, 198);
            this.lblRaportWzrost.Name = "lblRaportWzrost";
            this.lblRaportWzrost.Size = new System.Drawing.Size(35, 13);
            this.lblRaportWzrost.TabIndex = 5;
            this.lblRaportWzrost.Text = "label1";
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(183, 39);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(102, 23);
            this.btnSzczegoly.TabIndex = 6;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 326);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.lblRaportWzrost);
            this.Controls.Add(this.cbKraje);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.btnTemperatuara);
            this.Controls.Add(this.lbDane);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnTemperatuara;
        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.ComboBox cbKraje;
        private System.Windows.Forms.Label lblRaportWzrost;
        private System.Windows.Forms.Button btnSzczegoly;
    }
}

