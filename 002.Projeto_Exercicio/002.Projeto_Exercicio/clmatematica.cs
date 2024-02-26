using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clmatematica
    {

        public Int32 soma_Result = 0;
        public Int32 media_result = 0;
        public String numb_temp_soma;
        public String[] numb_temp_soma_arr;
        public int[] numb_arr_soma;

        public String numb_temp_med;
        public String[] numb_temp_med_arr;
        public Double[] numb_arr_med;
        public Int32 Calcular(TextBox textBox)
        {
            numb_temp_soma = textBox.Text;
            numb_temp_soma_arr = numb_temp_soma.Split(";");

            numb_arr_soma = new int[numb_temp_soma_arr.Length];

            for (int i = 0; i < numb_temp_soma_arr.Length; i++)
            {
                numb_arr_soma[i] = Convert.ToInt32(numb_temp_soma_arr[i]);
            }

            for (int i = 0; i < numb_arr_soma.Length; i++)
            {
               
                    soma_Result += numb_arr_soma[i];
              
            }

            return soma_Result;
        }

        public Double Calcular(TextBox textBox, int a)
        {
            numb_temp_med = textBox.Text;
            numb_temp_med_arr = numb_temp_med.Split(";");

            numb_arr_soma = new int[numb_temp_soma_arr.Length];

            for (int i = 0; i < numb_temp_soma_arr.Length; i++)
            {
                numb_arr_med[i] = Convert.ToDouble(numb_temp_med_arr[i]);
            }

            //calcular a media

            return media_result;
        }
    }
}
