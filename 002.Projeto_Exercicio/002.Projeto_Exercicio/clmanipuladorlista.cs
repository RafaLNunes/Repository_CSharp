using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clmanipuladorlista
    {
        public String Entrada_lista_temp;
        public String[] lista_temp;
        public Int32[] lista;
        public Int32[] Lista_Final;
        public Int32 retirada;
        public Int32 retirar;


        public Int32[] RemoverElemento(TextBox textBox, TextBox textBox1)
        {
            Entrada_lista_temp = textBox.Text;
            lista_temp = Entrada_lista_temp.Split(";");
            lista = new int[lista_temp.Length];

            for (int i = 0; i < lista_temp.Length;i++)
            {
                lista[i] = Convert.ToInt32(lista_temp[i]);
            }
            
            for (int i = 0;i < lista.Length; i++)
            {
                MessageBox.Show($"O {i+1}° número: {lista[i]}\nDe Indice: {i}");
            }




  
            

                textBox1.Focus();
            

            return Lista_Final;
        }

        public int RemoverElemento(TextBox textBox1, int nada)
        {
            retirar = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < lista.Length; i++)
            {
                if (i == retirada)
                {
                    lista[i] = 0;
                }
            }
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != 0)
                {
                    MessageBox.Show($"O {i + 1}° número: {lista[i]}\nDe Indice: {i}");
                }
            }
            return 0;

        }

        public int RemoverElemento(TextBox textBox1)
        {

            retirada = Convert.ToInt32(textBox1.Text);

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == retirada)
                {
                    lista[i] = 0;
                }
            }

            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] != 0)
                {
                    MessageBox.Show($"O {i + 1}° número: {lista[i]}\nDe Indice: {i}");
                }
            } return 0;
        }


    }
}
