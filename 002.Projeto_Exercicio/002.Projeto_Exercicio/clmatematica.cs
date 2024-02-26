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
        public String numb_temp;
        public String[] numb_temparr;
        public Int32[][] numb_arr;
        public Int32 Calcular(TextBox textBox, Int32 a)
        {
            numb_temp = textBox.Text;
            numb_temparr = numb_temp.Split(";");

            for (int i = 0; i < numb_temparr.Length; i++)
            {
                for (int j = 0; j < numb_temparr[i].Length; j++)
                {
                    numb_arr[i][j] = Convert.ToInt32(numb_temparr[i][j]);
                }
            }

            for (int i = 0; i < numb_arr.Length; i++)
            {
                for(int j = 0; j < numb_arr[i].Length; j++)
                {
                    soma_Result += numb_arr[i][j];
                }
            }

            return soma_Result;
        }
    }
}
