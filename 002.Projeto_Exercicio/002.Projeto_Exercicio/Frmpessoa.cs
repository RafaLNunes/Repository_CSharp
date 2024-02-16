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
    public partial class Frmpessoa : Form
    {
        public Frmpessoa()
        {
            InitializeComponent();
        }

        private void Apresentar_Click(object sender, EventArgs e)
        {
            clpessoa ps = new clpessoa();
            ps.nome = textname.Text;
            ps.idade = Convert.ToInt32(textidade.Text);

            ps.apresentar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void operacoesMatematicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
