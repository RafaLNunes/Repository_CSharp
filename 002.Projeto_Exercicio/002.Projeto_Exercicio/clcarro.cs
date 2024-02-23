using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcarro
    {

        public String Marca;
        public String Modelo;

        public String Descricao(TextBox textBox, TextBox textBox1, String var1, String var2, Int32 Cont) {


            if(!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text))
            {
                Marca = textBox.Text;
                Modelo = textBox1.Text;

                var1 = textBox.Text;
                var2 = textBox1.Text;

            }
            Cont += 1;
            return Marca;
        }

    }
}
