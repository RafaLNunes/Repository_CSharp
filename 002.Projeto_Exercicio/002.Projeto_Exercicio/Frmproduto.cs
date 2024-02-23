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
    public partial class Frmproduto : Form
    {
        public Frmproduto()
        {
            InitializeComponent();
        }

        private void Frmproduto_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clproduto prod = new clproduto();
            prod.PrecoComDesconto(textnome, textprec, textdesc);
            MessageBox.Show($"Nome do Produto: {prod.nomePro}\nPreço original: {prod.preco}\nDesconto: {prod.desc}\nPreço com Desconto: {prod.descot}");
        }
    }
}
