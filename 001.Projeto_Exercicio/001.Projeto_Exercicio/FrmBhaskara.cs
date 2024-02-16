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

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;

            textBox1.Text = "enter the substitute for A";
            textBox2.Text = "enter the substitute for B";
            textBox3.Text = "enter the substitute for C";
        }

        Double A;
        Double B;
        Double C;
        Double delta;
        Double bhkp;
        Double bhkn;

        void marck(String MyText, TextBox textBox)
        {
            textBox.Paint += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == MyText)
                {
                    textBox.Clear();
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            marck("enter the substitute for A", textBox1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            marck("enter the substitute for B", textBox2);


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            marck("enter the substitute for C", textBox3);

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


            A = Double.Parse(textBox1.Text);
            B = Double.Parse(textBox2.Text);
            C = Double.Parse(textBox3.Text);
            delta = Math.Pow(B, 2) - 4 * A * C;
            bhkn = (-B - Math.Sqrt(delta)) / 2 * A;
            bhkp = (-B + Math.Sqrt(delta)) / 2 * A;

            label1.Text = $"X1 = {bhkn}";
            label3.Text = $"X2 = {bhkp}";
        }

        private void prestaçãoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestacao prestacao = new FrmPrestacao();
            prestacao.ShowDialog();
        }

        private void bhaskaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBhaskara bhaskara = new FrmBhaskara();
            bhaskara.ShowDialog();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno aluno = new FrmAluno();
            aluno.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentral home = new FrmCentral();
            home.ShowDialog();
        }
    }
}
