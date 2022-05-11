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
using System.Runtime.InteropServices;
namespace GirisEkranı
{
    public partial class KullanıcıGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public KullanıcıGiris()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int vparam, int lparam);
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string user = txtAdı.Text;
            string password = txtSifre.Text;
            string yetki = cmbYetki.Text;
            con = new SqlConnection("Data Source=DESKTOP-094I7K9;Initial Catalog=HMI;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Bilgi where kullanici_adi='" + txtAdı.Text + "' And şifre='" + txtSifre.Text +"'And Yetki='"+cmbYetki.Text +"'" ;
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                HMİEKRANİ enter = new HMİEKRANİ();
                enter.Show();
                this.Hide();
                
            }
        
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            SifremiUnuttum giris = new SifremiUnuttum();
            giris.Show();
            this.Hide();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            if (cmbYetki.Text == "Admin") 
            {
                Ayarlar giris = new Ayarlar();
                giris.Show();
                this.Hide();
            }
            
        }

       
    }
}

