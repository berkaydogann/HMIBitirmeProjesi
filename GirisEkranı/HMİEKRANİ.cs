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
using System.IO;
using OfficeOpenXml;
using System.Net;
using System.Net.Mail;
namespace GirisEkranı
{
    public partial class HMİEKRANİ : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public HMİEKRANİ()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            frmSicaklik giris = new frmSicaklik();
            giris.Show();
            this.Hide();
        }

        private void HMİEKRANİ_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
        int minute = 0, second = 0, splitsecond = 0;

        private void dur_Load(object sender, EventArgs e)
        {
         
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            minute = 0;
            second = 0;
            splitsecond = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnÖgütücü_Click(object sender, EventArgs e)
        {
            frmÖğütücü giris = new frmÖğütücü();
            giris.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ürün1, ürün2, ürün3, ürün4;
            ürün1 = Convert.ToDouble(textBox1.Text);
            ürün2 = Convert.ToDouble(textBox2.Text);
            ürün3 = Convert.ToDouble(textBox3.Text);
            ürün4 = Convert.ToDouble(textBox6.Text);
            
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Günlük Ürün Miktarı"].Points.Add(ürün1);
            chart1.Series["Günlük Ürün Miktarı"].Points.Add(ürün2);
            chart1.Series["Günlük Ürün Miktarı"].Points.Add(ürün3);
            chart1.Series["Günlük Ürün Miktarı"].Points.Add(ürün4);
            

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;

            using (var outStream = File.Open(@"C:\Users\berka\Desktop\Eğitimler\Okul Dersleri\BitirmeÖdevi\günlükgiris.xlsx", FileMode.Create, FileAccess.Write))
            {
                using (ExcelPackage xl = new ExcelPackage(outStream))
                {
                    ExcelWorksheet worksheetPC = xl.Workbook.Worksheets.Add("Sayfa 1");
                        worksheetPC.Cells[1, 1].Value = "Tarih";
                        worksheetPC.Cells[1, 2].Value = "Ürün Adı";
                        worksheetPC.Cells[1, 3].Value = "Miktar";
                        worksheetPC.Cells[2, 1].Value = DateTime.Now.ToString();
                        worksheetPC.Cells[2, 2].Value = "Ürün1";
                        worksheetPC.Cells[2, 3].Value = ürün1.ToString() + "kg";
                        worksheetPC.Cells[3, 1].Value = DateTime.Now.ToString();
                        worksheetPC.Cells[3, 2].Value = "Ürün2";
                        worksheetPC.Cells[3, 3].Value = ürün2.ToString() + "kg";
                        worksheetPC.Cells[4, 1].Value = DateTime.Now.ToString();
                        worksheetPC.Cells[4, 2].Value = "Ürün3";
                        worksheetPC.Cells[4, 3].Value = ürün3.ToString() + "kg";
                        worksheetPC.Cells[5, 1].Value = DateTime.Now.ToString();
                        worksheetPC.Cells[5, 2].Value = "Ürün4";
                        worksheetPC.Cells[5, 3].Value = ürün4.ToString() + "kg";


                    xl.Save();
                }
            }
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("sqlberkay@gmail.com");
            mail.To.Add("berkaydogann98@gmail.com");
            mail.Subject = "Günlük Ürün Miktari";
            mail.Body = "Merhaba," + "\n" + "Günlük gelen ürün miktarı aşağıdaki ekte yer almaktadır. Bilginize sunarız.";
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(@"C:\Users\berka\Desktop\Eğitimler\Okul Dersleri\BitirmeÖdevi\günlükgiris.xlsx");
            mail.Attachments.Add(attachment);
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential("sqlberkay@gmail.com", "Berkay123-");
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                frmKurutucu giris = new frmKurutucu();
                giris.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKakaoYagi giris = new frmKakaoYagi();
            giris.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splitsecond++;
            if(splitsecond == 100)
            {
                splitsecond = 0;
                second++;
                if(second == 60)
                {
                    second = 0;
                    minute++;
                }
                
            }
            lbl_minutes.Text = string.Format("{0:D2}", minute);
            lbl_Second.Text = string.Format("{0:D2}", second);
            llv_splitsecond.Text = string.Format("{0:D2}", splitsecond);
        }

        private void start_Load(object sender, EventArgs e)
        {
          
            
        }
        
    }
}
