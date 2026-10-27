namespace Sube2.HelloWindowsApp
{
    partial class frmKacanButon
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
            btnKac = new Button();
            pnlinfo = new Panel();
            label1 = new Label();
            lblSkor = new Label();
            pnlinfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnKac
            // 
            btnKac.Location = new Point(118, 201);
            btnKac.Margin = new Padding(3, 4, 3, 4);
            btnKac.Name = "btnKac";
            btnKac.Size = new Size(107, 109);
            btnKac.TabIndex = 0;
            btnKac.Text = "button1";
            btnKac.UseVisualStyleBackColor = true;
            btnKac.MouseMove += button1_MouseMove;
            // 
            // pnlinfo
            // 
            pnlinfo.BackColor = Color.FromArgb(192, 255, 192);
            pnlinfo.Controls.Add(label1);
            pnlinfo.Controls.Add(lblSkor);
            pnlinfo.Location = new Point(857, -3);
            pnlinfo.Margin = new Padding(3, 4, 3, 4);
            pnlinfo.Name = "pnlinfo";
            pnlinfo.Size = new Size(150, 696);
            pnlinfo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 248);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.Location = new Point(54, 137);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(0, 20);
            lblSkor.TabIndex = 0;
            // 
            // frmKacanButon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 693);
            Controls.Add(pnlinfo);
            Controls.Add(btnKac);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmKacanButon";
            Text = "frmKacanButon";
            SizeChanged += frmKacanButon_SizeChanged;
            pnlinfo.ResumeLayout(false);
            pnlinfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKac;
        private Panel pnlinfo;
        private Label lblSkor;
        private Label label1;
    }
}