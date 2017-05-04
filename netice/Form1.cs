using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int viza, final;
            double netice;
            viza = Convert.ToInt32(textBox1.Text);
            final = Convert.ToInt32(textBox2.Text);
            netice = viza * 0.4 + final * 0.6;
            if(netice>=45){
                label3.Text = "Kecdin";
            }
            else
            {
                label3.Text = "Qaldin";
            }
        }
    }
}
