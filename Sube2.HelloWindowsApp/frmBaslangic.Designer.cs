namespace Sube2.HelloWindowsApp
{
    partial class frmBaslangic
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
            btnAc = new Button();
            SuspendLayout();
            // 
            // btnAc
            // 
            btnAc.Location = new Point(141, 111);
            btnAc.Name = "btnAc";
            btnAc.Size = new Size(184, 168);
            btnAc.TabIndex = 0;
            btnAc.Text = "FormuAc";
            btnAc.UseVisualStyleBackColor = true;
            btnAc.Click += btnAc_Click;
            // 
            // frmBaslangic
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 439);
            Controls.Add(btnAc);
            Name = "frmBaslangic";
            Text = "frmBaslangic";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAc;
    }
}