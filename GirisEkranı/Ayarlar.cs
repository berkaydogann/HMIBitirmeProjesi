using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
namespace GirisEkranı
{
    public partial class Ayarlar : Form
    {
       
        public Ayarlar()
        {
            InitializeComponent();
        }

        private void Ayarlar_Load(object sender, EventArgs e)
        {
        
            
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = lblKullaniciAdi.Text;
            string email = lblMail.Text;
            string sifre = lblSifre.Text;
            string yetki = lblYetki.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-094I7K9;Initial Catalog=HMI;Integrated Security=True");
            SqlCommand komut;
            SqlDataReader read;
            
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "İnsert into Bilgi values('" + KullaniciAdi + "','" + email + "','" + sifre + "','" + yetki + "')";
            baglanti.Close();

            MessageBox.Show("Üye Eklendi");
           
        }
    }
}
