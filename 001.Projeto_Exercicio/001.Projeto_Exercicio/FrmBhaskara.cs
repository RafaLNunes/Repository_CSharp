using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001.Projeto_Exercicio
{
    public partial class FrmBhaskara : Form
    {
        public FrmBhaskara()
        {
            InitializeComponent();
        }

        float A;
        float B;
        float C;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void FrmBhaskara_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label2.Text = $"{textBox1.Text}x2+";

            label2.Text += $"{textBox2.Text}x-";

            label2.Text += $"{textBox3.Text}=0";

        }
    }
}
