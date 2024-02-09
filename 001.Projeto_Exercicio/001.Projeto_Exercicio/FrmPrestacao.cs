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
    }
}
