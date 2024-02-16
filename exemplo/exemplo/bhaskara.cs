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
    public partial class bhaskara : Form
    {
        public bhaskara()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // delta = b²-4ac
            // (-b + √delta)/2a
            // (-b - √delta)/2a
            /*
             A
             B
             C
             delta
            */
            Double A = Convert.ToDouble(textBox1.Text);
            Double B = Convert.ToDouble(textBox2.Text);
            Double C = Convert.ToDouble(textBox3.Text);
            Double delta = Math.Pow(B, 2) - 4 * A * C;

            if (delta < 0)
            {
                MessageBox.Show("Tivemos um problema no calculo");
            }
            else
            {
                Double calculo_bhaskara1 = (-B + Math.Sqrt(delta)) / 2 * A;
                Double calculo_bhaskara2 = (-B - Math.Sqrt(delta)) / 2 * A;

                MessageBox.Show("x1 de acordo com Bhaskara: " + calculo_bhaskara1 + "\nx2 de acordo com Bhaskara: " + calculo_bhaskara2);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

