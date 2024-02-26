using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcalculadorageometrica
    {
        // circulo
        public Double raio_cir;
        public Double area_cir;
        public Double CalcularArea(TextBox textBox)
        {
            raio_cir = Convert.ToDouble(textBox.Text);
            Double pi = Math.PI;

            area_cir = pi * (Math.Pow(raio_cir, 2));

            return area_cir;
        }

        //triangulo
        public Double base_tri;
        public Double alt_tri;
        public Double area_tri;
        public Double CalcularArea(TextBox textBox, TextBox textBox1)
        {
            base_tri = Convert.ToDouble(textBox.Text); 
            alt_tri = Convert.ToDouble(textBox1.Text);

            area_tri = (base_tri * alt_tri) / 2;

            return area_tri;
        }

        //retangulo
        public Double larg_ret;
        public Double alt_ret;
        public Double area_ret;
        public Double CalcularArea(TextBox textBox, TextBox textBox1, int nada)
        {
            larg_ret = Convert.ToDouble(textBox.Text);
            alt_ret = Convert.ToDouble(textBox1.Text);

            area_ret = (alt_ret * larg_ret);

            return area_ret;
        }

    }
}
