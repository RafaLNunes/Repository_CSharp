using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clconversor
    {
        public Double Dolar;
        public Double Real;
        public Double dod;
        public Double Converter(TextBox textBox)
        {
            Double dolar;
            dolar = Convert.ToDouble(textBox.Text);
            dod = 4.95;

            Real = dolar / dod;
            Real.ToString("F2");
            return Real;
        }
        public Double Converter(TextBox textBox, TextBox textBox1)
        {
            Double real;
            Double dolar;
            real = Convert.ToDouble(textBox.Text);
            dolar = 4.95;
            Dolar = real * dolar;

            textBox1.Text = Dolar.ToString("F2");

            return Dolar;
        }
    }
}

