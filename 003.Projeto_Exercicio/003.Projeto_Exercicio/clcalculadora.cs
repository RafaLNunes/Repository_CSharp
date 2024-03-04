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

        public Int32 Calc(TextBox textBox, TextBox textBox1, Label label) // sum
        {

            String MyText;

            try
            {
                Int32 v1 = Convert.ToInt32(textBox.Text);   
                Int32 v2 = Convert.ToInt32(textBox1.Text);

                resultado_soma = v1 + v2;

                MyText = "Numb 1 + Numb 2 = " + resultado_soma.ToString();
                label.Text = MyText;

                label.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em soma: {ex.Message}", "ERRO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado_soma;
        }
        public Int32 Calc(TextBox textBox, TextBox textBox1, Label label, int numb) // sub
        {

            String MyText;

            try
            {
                Int32 v1 = Convert.ToInt32(textBox.Text);
                Int32 v2 = Convert.ToInt32(textBox1.Text);

                resultado_sub = v1 - v2;

                MyText = "Numb 1 - Numb 2 = " + resultado_sub.ToString();
                label.Text = MyText;

                label.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em Subtração: {ex.Message}", "ERRO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado_sub;
        }

        public Int32 Calc(TextBox textBox, TextBox textBox1, Label label, int numb, int numb2) // div
        {

            String MyText;

            try
            {
                Int32 v1 = Convert.ToInt32(textBox.Text);
                Int32 v2 = Convert.ToInt32(textBox1.Text);

                resultado_sub = v1 / v2;

                MyText = "Numb 1 ÷ Numb 2 = " + resultado_sub.ToString();
                label.Text = MyText;

                label.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em Divisão: {ex.Message}", "ERRO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado_div;
        }

        public Int32 Calc(TextBox textBox, TextBox textBox1, Label label, int numb, int numb2, int numb3) // mult
        {

            String MyText;

            try
            {
                Int32 v1 = Convert.ToInt32(textBox.Text);
                Int32 v2 = Convert.ToInt32(textBox1.Text);

                resultado_sub = v1 * v2;

                MyText = "Numb 1 X Numb 2 = " + resultado_sub.ToString();
                label.Text = MyText;

                label.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro em multiplicação: {ex.Message}", "ERRO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado_mult;
        }

    }
}
