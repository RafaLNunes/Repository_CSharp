using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _002.Projeto_Exercicio
{
    internal class claluno
    {
        public Double[] nota = new Double[5];
        public String nome;
        public Double media(TextBox textBox, TextBox textBox1)
        {
            Double media = 0;
            Int32 cont = nota.Length;
            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text) ){
                nome = textBox.Text;
                nota[1] = Convert.ToDouble(textBox1.Text);
                MessageBox.Show($"Sua nota {cont+1} é: {nota[1]}");
                media += nota[1];
            }

            textBox1.Text = null;

            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text) ){
                for (int i = 1; i < 6; i++)
                {
                    textBox.Text = nome;
                    nota[i] = Convert.ToDouble(textBox1.Text);
                    MessageBox.Show($"Sua nota {i} é: {nota[i]}");
                    media += nota[i];
                    textBox1.Text = null;
                }
            }
            else
            {
                textBox.Focus();
            }

            return media;
        }
    }
}
