namespace Schlachtfest2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Pils = new System.Windows.Forms.Label();
            this.btn_Pils2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Pils = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Pils
            // 
            this.lbl_Pils.AutoSize = true;
            this.lbl_Pils.Location = new System.Drawing.Point(243, 210);
            this.lbl_Pils.Name = "lbl_Pils";
            this.lbl_Pils.Size = new System.Drawing.Size(74, 13);
            this.lbl_Pils.TabIndex = 12;
            this.lbl_Pils.Text = "0 * 1.50€ = 0€";
            // 
            // btn_Pils2
            // 
            this.btn_Pils2.Location = new System.Drawing.Point(243, 235);
            this.btn_Pils2.Name = "btn_Pils2";
            this.btn_Pils2.Size = new System.Drawing.Size(75, 23);
            this.btn_Pils2.TabIndex = 11;
            this.btn_Pils2.Text = "delete 1";
            this.btn_Pils2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Pils
            // 
            this.btn_Pils.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_Pils.Location = new System.Drawing.Point(91, 198);
            this.btn_Pils.Name = "btn_Pils";
            this.btn_Pils.Size = new System.Drawing.Size(146, 61);
            this.btn_Pils.TabIndex = 9;
            this.btn_Pils.Text = "Pils";
            this.btn_Pils.UseVisualStyleBackColor = true;
            this.btn_Pils.Click += new System.EventHandler(this.btn_Pils_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 589);
            this.Controls.Add(this.lbl_Pils);
            this.Controls.Add(this.btn_Pils2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Pils);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Pils;
        private System.Windows.Forms.Button btn_Pils2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Pils;
    }
}

