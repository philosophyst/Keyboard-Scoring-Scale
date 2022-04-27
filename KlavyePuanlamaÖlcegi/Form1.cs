using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlavyePuanlamaÖlcegi
{
    public partial class KlavyePuanlamaOlcegi : Form
    {
        public KlavyePuanlamaOlcegi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ESENLİKLER");
            try
            {
                button1.Enabled = false; button2.Enabled = false; button3.Enabled = false; textBox3.Enabled = false; textBox4.Enabled = false; textBox5.Enabled = false; textBox6.Enabled = false; textBox7.Enabled = false;

                textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text = "0"; textBox6.Text = "0"; textBox7.Text = "0";
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int hata = Convert.ToByte(textBox4.Text), hatapuani = 0;
                if (radioButton1.Checked == true)
                {
                    hatapuani = hata * 5;
                }
                else if (radioButton2.Checked == true)
                {
                    hatapuani = hata * 10;
                }
                else if (radioButton3.Checked == true)
                {
                    hatapuani = hata * 15;
                }

                int vurussayisi = Convert.ToInt32(textBox3.Text);
                int netvurus = vurussayisi - hatapuani;
                int kelime = netvurus / 5;

                textBox5.Text = Convert.ToString(hatapuani);
                textBox6.Text = Convert.ToString(netvurus);
                textBox7.Text = Convert.ToString(kelime);
            }

            catch (Exception)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temizle();
        }
        
        private void temizle(){
            try
            {
                textBox3.Text = "0";
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
            }
            catch (Exception)
            {
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true;
            }
            catch (Exception)
            {
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = true; button2.Enabled = true; button3.Enabled = true; textBox3.Enabled = true; textBox4.Enabled = true;
            }
            catch (Exception)
            {
            }
        }
    }
}






