using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sube2.HelloWindowsApp
{
    public partial class frmAcilan : Form
    {

        frmBaslangic baslangic;
        public frmAcilan( frmBaslangic baslangic)
        {
            InitializeComponent();
            this.baslangic = baslangic;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // baslangic.Text = txtBaslik.Text; // baslangic formunun text özelliğini açılan formdaki textBox1'in text özelliğine eşitledik.

            Application.OpenForms["frmBaslangic"].Text = txtBaslik.Text; //içinde açık olan formları tutuyor collection openforms. OpenForms["frmBaslangic"] ile frmBaslangic formunu açtık ve Text özelliğini txtBaslik.Text ile eşitledik.







            // Application.OpenForms["frmBaslangic"] ile frmBaslangic formunu açtık ve Text özelliğini txtBaslik.Text ile eşitledik.
        }
        //private void button1_Click(object sender, EventArgs e)




        //collection aynı türde birden fazla yapıyı bir arada tutmak için kullanılan yapılardır. List, Dictionary, ArrayList gibi yapılar collection olarak adlandırılır. Bu yapılar sayesinde birden fazla veriyi tek bir değişkende saklayabiliriz ve bu verilere kolayca erişebiliriz.
    }
}
