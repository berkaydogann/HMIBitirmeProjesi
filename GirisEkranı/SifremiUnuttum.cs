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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            sqlbaglantısı bgln = new sqlbaglantısı();
           
            SqlCommand komut = new SqlCommand("Select * From Bilgi Where kullanici_adi='" + textBox1.Text.ToString() + "'and eposta= '" + textBox2.Text.ToString() + "'",bgln.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if(bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();

                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    string tarih = DateTime.Now.ToLongDateString();
                    string mailadresin = ("sqlberkay@gmail.com");
                    string sifre = ("Berkay123-");
                    string smtpsrvr = ("smtp.gmail.com");
                    string kime = (oku["eposta"].ToString());
                    string konu = ("Şifre Hatırlatma Talebi");
                    string yaz = ("Sayın, Kullanıcımız " + "\n"+"Bizden" + tarih +"İtibari ile şifre hatırlatma talebinde bulundunuz."+"\n"+"Parolanız:"+oku["şifre"].ToString()+"\n" + "İyi Günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("Şifre gönderim gerçekleşti...");
                    this.Hide();
                }
                catch(Exception Hata)
                {
                    MessageBox.Show("Mail Gönderme Hatasaı!", Hata.Message);

                }
            }
        }
    }
}
