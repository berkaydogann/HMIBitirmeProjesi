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
    public partial class frmKakaoYagi : Form
    {
        public frmKakaoYagi()
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
                label2.Text = "Beta() tipi kristal";
            else if (listBox1.SelectedIndex == 1)
                label2.Text = "Beta üstü(') tipi kristal";
            else if (listBox1.SelectedIndex == 2)
                label2.Text = "Alfa() tipi kristal";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
                label4.Text = "33-350 C";
            else if (listBox2.SelectedIndex == 1)
                label4.Text = "26-290C";
            else if (listBox2.SelectedIndex == 2)
                label4.Text = "21-240C";
            
        }

        private void standardControl3_Load(object sender, EventArgs e)
        {

        }

        private void standardControl8_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(textBox1.Text + " ton çekirdeğin " + listBox1.SelectedItem.ToString() +" biçiminde ve "+listBox2.SelectedItem.ToString()+  " derece sıcaklıkta yağ çıkarma işlemi başlayacaktır." + "\n Bu adımdan sonra iptal edemezsiniz.", "Kakao yağı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("İşlem onaylandı");
                standardControl1.DiscreteValue2 = true;
                standardControl6.DiscreteValue2 = true;
                standardControl7.DiscreteValue2 = true;
                standardControl8.DiscreteValue2 = true;
                standardControl3.DiscreteValue2 = true;

            }
            else if (dialog == DialogResult.No)
            {
                MessageBox.Show("İşlem onaylanmadı.");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            label2.Visible = false;
            label4.Visible = false;
            textBox1.Clear();
            standardControl1.DiscreteValue2 = false;
            standardControl6.DiscreteValue2 = false;
            standardControl7.DiscreteValue2 = false;
            standardControl8.DiscreteValue2 = false;
            standardControl3.DiscreteValue2 = false;
        }
    }
}
