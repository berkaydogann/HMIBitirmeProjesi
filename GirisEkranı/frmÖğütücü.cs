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
    public partial class frmÖğütücü : Form
    {
        
        public frmÖğütücü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HMİEKRANİ enter = new HMİEKRANİ();
            enter.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            if (listBox1.SelectedIndex == 0)
                label2.Text = "50";
            else if (listBox1.SelectedIndex == 1)
                label2.Text = "75";
            else if (listBox1.SelectedIndex == 2)
                label2.Text = "100";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Kakao çekirdekleri öğütme işlemi başlayacaktır.\n Bu adımdan sonra iptal edemezsiniz.", "Öğütme İşlemi", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                MessageBox.Show("Öğütme işlemi başlıyor.");
                standardControl1.DiscreteValue2 = true;
                standardControl10.DiscreteValue2 = true;
                standardControl11.DiscreteValue2 = true;
                standardControl12.DiscreteValue2 = true;
                standardControl13.DiscreteValue2 = true;
                standardControl14.DiscreteValue2 = true;
                standardControl15.DiscreteValue2 = true;

            }
            else if(dialog== DialogResult.No)
            {
                MessageBox.Show("Öğütme işlemi onaylanmadı.");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
                label6.Text = "35-150C"; 
            else if (listBox2.SelectedIndex == 1)
                label6.Text = "150-350C";
             else if (listBox2.SelectedIndex == 2)
                label6.Text = "350-500C";
                
        }

        private void frmÖğütücü_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == 0)
                label7.Text = "30 dakika";
            else if (listBox3.SelectedIndex == 1)
                label7.Text = "50 dakika";
            else if (listBox3.SelectedIndex == 2)
                label7.Text = "75 dakika";
        }

        private void standardControl6_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex == 0)
                label11.Text = listBox4.SelectedItem.ToString();
            else if (listBox4.SelectedIndex == 1)
                label11.Text = listBox4.SelectedItem.ToString();
            else if (listBox4.SelectedIndex == 2)
                label11.Text = listBox4.SelectedItem.ToString();
                
        }

        private void cutawayControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
