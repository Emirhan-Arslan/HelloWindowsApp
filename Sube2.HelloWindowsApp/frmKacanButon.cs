using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sube2.HelloWindowsApp
{
    public partial class frmKacanButon : Form
    {
        int skor = 0;



        public frmKacanButon(String ad, String soyad)
        {
            InitializeComponent();
            txtAd = ad;
            txtSoyad = soyad;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            var rnd = new Random();
            int x = rnd.Next(this.ClientSize.Width - btnKac.Width - pnlinfo.Width);
            int y = rnd.Next(this.ClientSize.Height - btnKac.Height);
            btnKac.Location = new Point(x, y);
            skor++;
            lblSkor.Text = skor.ToString();
        }

        private void frmKacanButon_SizeChanged(object sender, EventArgs e)
        {
            pnlinfo.Location = new Point(this.ClientSize.Width - pnlinfo.Width, 0);
            pnlinfo.Height = this.ClientSize.Height;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}


//piksel nedir , çözünürlük nedir, düşük çözünürlük yüksek çözünürlük, çözünürlük neyle ölçülür, inç nedir, çözünürlüğü iyi mi kötü mü nasıl anlaşılır,
//
//
//ekran boyutu nedir, ekran çözünürlüğü nedir, ekran çözünürlüğü neyle ölçülür, ekran çözünürlüğü neye göre değişir
//
//dpi nedir, ppi nedir, ekran çözünürlüğü nedir, ekran boyutu nedir, ekran boyutu ile çözünürlük arasındaki fark nedir, ekran boyutu ile dpi arasındaki fark nedir, ekran boyutu ile ppi arasındaki fark nedir, ekran boyutu ile piksel arasındaki fark nedir, ekran boyutu ile inç arasındaki fark nedir, ekran boyutu ile santimetre arasındaki fark nedir, ekran boyutu ile milimetre arasındaki fark nedir, ekran boyutu ile metre arasındaki fark nedir, ekran boyutu ile kilometre arasındaki fark nedir, ekran boyutu ile mil arasındaki fark nedir, ekran boyutu ile feet arasındaki fark nedir, ekran boyutu ile yard arasındaki fark nedir, ekran boyutu ile mile arasındaki fark nedir, ekran boyutu ile light year arasındaki fark nedir, ekran boyutu ile parsec arasındaki fark nedir, ekran boyutu ile astronomical unit arasında ki fark nedir


//
//

//