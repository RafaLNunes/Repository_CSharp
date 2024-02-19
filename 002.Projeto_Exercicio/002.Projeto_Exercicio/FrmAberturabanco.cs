using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002.Projeto_Exercicio
{
    public partial class FrmAberturabanco : Form
    {
        public FrmAberturabanco()
        {
            InitializeComponent();
        }

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


        private void button3_Click(object sender, EventArgs e)
        {
            clbanco prebanco = new clbanco();
            prebanco.cot_limit(500, textBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clbanco prebanco = new clbanco();
            prebanco.cot_limit(200, textBox1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clbanco prebanco = new clbanco();
            prebanco.cot_limit(100, textBox1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAberturabanco_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            marck("Escreva o seu saldo", textBox1);
        }
    }
}
