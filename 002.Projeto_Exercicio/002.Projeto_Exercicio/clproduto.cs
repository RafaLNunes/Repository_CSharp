using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clproduto
    {

        public Double descot;
        public String nomePro;
        public Double preco;
        public Double desc;

        public Double PrecoComDesconto(TextBox textBox, TextBox textBox1, TextBox textBox2)
        {
            nomePro = textBox.Text;
            preco = Convert.ToDouble(textBox1.Text);
            desc = Convert.ToDouble(textBox2.Text);

            desc = (preco *(desc / 100));

            descot = preco - desc;

            return descot;
        }
    }
}
