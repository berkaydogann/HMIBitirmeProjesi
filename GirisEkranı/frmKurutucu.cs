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
    public partial class frmKurutucu : Form
    {
        public frmKurutucu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                HMİEKRANİ enter = new HMİEKRANİ();
                enter.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            standardControl5.DiscreteValue2 = true;
            standardControl3.DiscreteValue2 = true;
            standardControl2.DiscreteValue2 = true;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Green;
            MessageBox.Show("Kurutma İşlemi Başladı.");
            if (radioButton1.Checked == true)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label1.Text = (radioButton1.Text + " nem miktarı ile hızlı kurutma başladı.");
                }
                if (listBox1.SelectedIndex == 1)
                {
                    label1.Text = radioButton1.Text + " nem miktarı ile yavaş kurutma başladı.";
                }
            }
            else
            {
                if (listBox1.SelectedIndex == 0)
                {
                    label1.Text = radioButton2.Text + " nem miktarı ile hızlı kurutma başladı.";
                }
                if (listBox1.SelectedIndex == 1)
                {
                    label1.Text = radioButton2.Text + " nem miktarı ile yavaş kurutma başladı.";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            standardControl5.DiscreteValue2 = false;
            standardControl3.DiscreteValue2 = false;
            standardControl2.DiscreteValue2 = false;
            
            label1.Visible = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            listBox1.ClearSelected();
            label3.Visible = false;
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }

        private void standardControl5_Load(object sender, EventArgs e)
        {

        }

        private void standardControl1_Load(object sender, EventArgs e)
        {
            
            
           
        }

        private void standardControl3_Load(object sender, EventArgs e)
        {

        }

        private void standardControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
