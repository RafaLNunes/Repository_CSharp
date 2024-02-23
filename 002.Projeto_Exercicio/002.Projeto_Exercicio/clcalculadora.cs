using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcalculadora
    {

        public Int32 somada;
        public Double Somada;
        public Int32 Somar(Int32 numero, TextBox textBox, TextBox textBox1)
        {
            Int32 numb1 = Convert.ToInt32(textBox.Text);
            Int32 numb2 = Convert.ToInt32(textBox1.Text);

            somada = numb1 + numb2;

            return somada;
        }
        public Double Somar( TextBox textBox, TextBox textBox1)
        {
            Double numb1 = Convert.ToDouble(textBox.Text);
            Double numb2 = Convert.ToDouble(textBox1.Text);

            Somada = numb1 + numb2;

            return Somada;
        }

    }
}
