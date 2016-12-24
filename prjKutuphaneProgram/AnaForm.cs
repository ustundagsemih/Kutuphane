using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjKutuphaneProgram
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            lblKisi.Text = Login.AdSoyad + "Olarak Giriş Yaptınız Yetkiniz" + Login.Yetki;
            if (Login.Yetki == "Admin")
            {
                btnYeni.Enabled = true;
            }
            else
            {
                btnYeni.Enabled = false;
            }

        }

        
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show ("Çıkmak İstediğinizden Emin Misiniz?","Çıkış",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
           
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            YeniKayit ac = new YeniKayit();
            ac.ShowDialog();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
