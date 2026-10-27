using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmBaslangic : Form
    {
        public frmBaslangic()
        {
            InitializeComponent();
        }

        private void btnAc_Click(object sender, EventArgs e)  //buton efekti defaulttu iki tıklamak yeterli
        {
            //yeni form açma yöntemi
            var frm = new frmAcilan(this); // this şuan veri tipi frmBaslangic
                                           //
                                           // olan formu temsil ediyor. frmAcilan formuna gönderiyoruz. frmAcilan formunda bu formu kullanabilmek için constructor oluşturduk.

            frm.Show(); // show göstermek demek göster diyor açtığımızı - - - Oluşturulan frm formu ekranda kullanıcıya gösterilir
        }
    }
}


// HAFTAYA BUNLARLA İLGİLİ SORU SORCAM VE NOT VERCEM BUNA GÖRE SORU SORMAK İÇİN BUNLARI İYİ ANLAMAN LAZIM
//

//
//

//
//

// 
//
//

//
//