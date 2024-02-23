using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class cltriangulo
    {
        public Double Perimetro_resu = 0;
        public Double Perimetro(TextBox textBox, TextBox textBox1, TextBox textBox2) {

        if(!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)) {
                Double LA = Convert.ToDouble(textBox.Text);
                Double LB = Convert.ToDouble(textBox1.Text);
                Double LC = Convert.ToDouble(textBox2.Text);

                Perimetro_resu = LA + LB + LC;
            }

            return Perimetro_resu;
        }
    }
}
