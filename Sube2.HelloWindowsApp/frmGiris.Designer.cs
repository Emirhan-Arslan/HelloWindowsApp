namespace Sube2.HelloWindowsApp
{
    partial class frmGiris
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
            grpKullanici = new GroupBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            btnGiris = new Button();
            grpKullanici.SuspendLayout();
            SuspendLayout();
            // 
            // grpKullanici
            // 
            grpKullanici.Controls.Add(btnGiris);
            grpKullanici.Controls.Add(lblSoyad);
            grpKullanici.Controls.Add(lblAd);
            grpKullanici.Controls.Add(txtSoyad);
            grpKullanici.Controls.Add(txtAd);
            grpKullanici.Location = new Point(118, 34);
            grpKullanici.Name = "grpKullanici";
            grpKullanici.Size = new Size(583, 329);
            grpKullanici.TabIndex = 0;
            grpKullanici.TabStop = false;
            grpKullanici.Text = "kullaniciBilgileri";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(211, 65);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(237, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(211, 119);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(237, 27);
            txtSoyad.TabIndex = 1;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(149, 72);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 2;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(140, 126);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 3;
            lblSoyad.Text = "Soyad";
            lblSoyad.Click += lblSoyad_Click;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(211, 174);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(237, 59);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giris";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // frmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpKullanici);
            Name = "frmGiris";
            Text = "frmGiris";
            grpKullanici.ResumeLayout(false);
            grpKullanici.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKullanici;
        private Label lblSoyad;
        private Label lblAd;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Button btnGiris;
    }
}