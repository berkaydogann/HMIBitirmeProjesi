using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisEkranı
{
    public partial class frmSicaklik : Form
    {
        

        public frmSicaklik()
        {
            InitializeComponent();
        }

        private void trkSicaklik1_Scroll(object sender, EventArgs e)
        {
            lblSicaklik.Text = trkSicaklik1.Value.ToString();
            double sicak;
            sicak = Convert.ToDouble(lblSicaklik.Text);
            

            chart1.Series["Sıcaklık İlişkisi"].Points.Add(sicak);
            chart1.Series["Sıcaklık İlişkisi"].Points[0].Color = Color.Red;
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblsogutucu1.Text = trackBar1.Value.ToString();
            standardControl1.DiscreteValue2 = true;
            double soguk;
            soguk = Convert.ToDouble(lblsogutucu1.Text);
            chart2.Series["Soğutucu İlişkisi"].Points.Add(soguk);
            chart2.Series["Soğutucu İlişkisi"].Points[0].Color = Color.Black;
        }

        private void frmSicaklik_Load(object sender, EventArgs e)
        {

        }

        private void standardControl1_Load(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HMİEKRANİ enter = new HMİEKRANİ();
            enter.Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
