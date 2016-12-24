using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prjKutuphaneProgram
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string Yetki;
        public static string AdSoyad;
        private void button1_Click(object sender, EventArgs e)
        {
                string yol = "Provider=Microsoft.ACE.Oledb.16.0;data source=DbRehber.accdb;";
            OleDbConnection baglanti = new OleDbConnection(yol);
            baglanti.Open();

            string sql = "SELECT * FROM tblKullanicilar WHERE KullaniciAd =[@KullaniciAd] And Sİfre =[@Sifre];";            

            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter(sql, baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@KullaniciAd", txtKullaniciAd.Text);
            adp.SelectCommand.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            adp.Fill(dt);

            if (dt.Rows.Count == 0) 
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            else
            {
                Yetki = dt.Rows[0]["Yetki"].ToString();
                AdSoyad = dt.Rows[0]["AdSoyad"].ToString();
                this.Hide();
               AnaForm ac = new AnaForm();
                ac.ShowDialog();
                         }
        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
          