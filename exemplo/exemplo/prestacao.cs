using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo
{
    public partial class prestacao : Form
    {
        public prestacao()
        {
            InitializeComponent();
        }

        private void médiaDoAlunoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            aluno ventilador = new aluno();
            ventilador.ShowDialog();
        }

        private void bhaskaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            bhaskara quadrado = new bhaskara();
            quadrado.ShowDialog();
        }

        private void prestaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestacao preste = new prestacao();
            preste.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PRESTAÇÃO:=VALOR+(VALOR*(TAXA/100) *TEMPO)

            Double valor = Convert.ToDouble(textBox1.Text);
            Double taxa = Convert.ToDouble(textBox3.Text);
            Double tempo = Convert.ToDouble(textBox2.Text);
            Double acao = valor + ((valor * (taxa / 100)) * tempo);

            MessageBox.Show("Prestação: R$" + acao);
        }
    }
}
