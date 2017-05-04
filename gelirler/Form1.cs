using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gelirler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gunluk_gelir, gun_sayi,brut_gelir;
            float faiz,net_gelir;
            gunluk_gelir = Convert.ToInt32(textBox1.Text);
            gun_sayi = Convert.ToInt32(textBox2.Text);
            brut_gelir = gunluk_gelir * gun_sayi;
            if (brut_gelir >= 1000)
            {
                faiz = brut_gelir * 0.18F;
            }
            else
            {
                faiz = brut_gelir * 0.04F;
            }
            net_gelir = brut_gelir - faiz;
            label6.Text = faiz.ToString();
            label5.Text = net_gelir.ToString();
        }
    }
}
