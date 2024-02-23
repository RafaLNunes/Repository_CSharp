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
        public Double return_media;
        public Double media(TextBox textBox, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            Double media = 0;

            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text))
            {
                nota[0] = Convert.ToDouble(textBox1.Text);
                nota[1] = Convert.ToDouble(textBox2.Text);
                nota[2] = Convert.ToDouble(textBox3.Text);
                nota[3] = Convert.ToDouble(textBox4.Text);
                nota[4] = Convert.ToDouble(textBox5.Text);

                for (int i = 0; i < 5; i++)
                {
                    media += nota[i];
                }
            }
            else
            {
                textBox.Focus();
            }

            return_media = media;
            return media;
        }

        public Double Entre_Nota()
        {
            Double media = return_media;
            for (int i = 0;i<5;i++ )
            {
                MessageBox.Show($"Sua nota {i+1} é: {nota[i]}");
            }
            return media;
        }
    }
}
