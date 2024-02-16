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
    public partial class FrmPrestacao : Form
    {
        public FrmPrestacao()
        {
            InitializeComponent();
        }
        //Service commission=value+(value*(fee/100)*time)
        Double Sc;
        Double Value;
        Double fee;
        Double time;

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

        private void FrmPrestacao_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentral home = new FrmCentral();
            home.ShowDialog();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno aluno = new FrmAluno();
            aluno.ShowDialog();
        }

        private void bhaskaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBhaskara bhk = new FrmBhaskara();
            bhk.ShowDialog();
        }

        private void comJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestacao prestacao = new FrmPrestacao();
            prestacao.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            marck("enter the amount of the installment", textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            marck("enter the time of service", textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            marck("enter your fee", textBox3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Service commission=value+(value*(fee/100)*time)
            Value = Convert.ToDouble(textBox1.Text);
            time = Convert.ToDouble(textBox2.Text);
            fee = Convert.ToDouble(textBox3.Text);

            Sc = Value + (Value * (fee / 100) * time);

        }
    }
}
