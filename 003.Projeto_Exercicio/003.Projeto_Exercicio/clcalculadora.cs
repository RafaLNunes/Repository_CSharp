using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Projeto_Exercicio
{
    internal class clcalculadora
    {

        public Int32 resultado_soma;
        public Int32 resultado_sub;
        public Int32 resultado_div;
        public Int32 resultado_mult;

        public Int32 Calc(TextBox textBox, TextBox textBox1)
        {
            Int32 v1 = Convert.ToInt32(textBox.Text);
            Int32 v2 = Convert.ToInt32(textBox1.Text);

            try
            {

            }catch (Exception ex)
            {

            }

            return resultado_soma;
        }
        public Int32 Calc(TextBox textBox, TextBox textBox1, int numb)
        {
            Int32 v1 = Convert.ToInt32(textBox.Text);
            Int32 v2 = Convert.ToInt32(textBox1.Text);

            try
            {

            }
            catch (Exception ex)
            {

            }

            return resultado_sub;
        }

    }
}
