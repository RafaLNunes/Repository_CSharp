using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo
{
    public partial class aluno : Form
    {
        public aluno()
        {
            InitializeComponent();
        }

        private void aluno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nota1;
            Double nota2;
            Double nota3;
            Double nota4;
            Double media;
            Double falta = Convert.ToDouble(textBox6.Text);
            nota1 = Convert.ToDouble(textBox2.Text);
            nota2 = Convert.ToDouble(textBox3.Text);
            nota3 = Convert.ToDouble(textBox4.Text);
            nota4 = Convert.ToDouble(textBox5.Text);
            media = (nota1 + nota2 + nota3 + nota4) / 4;

            String nome = textBox1.Text;
            //dias totais 200
            if (media < 70 && ((200 - falta) < ((200 / 100) * 70)))
            {
                MessageBox.Show("Sua nota é muito baixa para passar de Ano");
            }
            if (((200 - falta) < ((200 / 100) * 70)))
            {
                MessageBox.Show("Você faltou muito esse ano");
            }
            else
            {
                MessageBox.Show("A nota de: " + nome + " é: " + media + "\nSua presença é de: " + ((200 - falta) * 100) / 200 + "%");
            }


        }

        private void médiaDoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aluno ventilador = new aluno();
            ventilador.ShowDialog();
        }

        private void bhaskaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bhaskara quadrado = new bhaskara();
            quadrado.ShowDialog();
        }

        private void prestaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestacao preste = new prestacao();
            preste.ShowDialog();
        }
    }
}






/*

200 dia por ano

70% -> 200 = 140

200 - 10 = 190

190 < > 140 > passou pr presença < n passou por presença

*/