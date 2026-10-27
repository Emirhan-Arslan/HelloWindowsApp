namespace Sube2.HelloWindowsApp
{
    partial class frmAcilan
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
            button1 = new Button();
            txtBaslik = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(168, 121);
            button1.Name = "button1";
            button1.Size = new Size(125, 87);
            button1.TabIndex = 0;
            button1.Text = "Baslik Degistir";
            button1.UseVisualStyleBackColor = true;
            button1.ClientSizeChanged += button1_Click;
            button1.Click += button1_Click;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(104, 72);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(306, 27);
            txtBaslik.TabIndex = 1;
            txtBaslik.TextChanged += textBox1_TextChanged;
            // 
            // frmAcilan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 435);
            Controls.Add(txtBaslik);
            Controls.Add(button1);
            Name = "frmAcilan";
            Text = "frmAcilan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBaslik;
    }
}