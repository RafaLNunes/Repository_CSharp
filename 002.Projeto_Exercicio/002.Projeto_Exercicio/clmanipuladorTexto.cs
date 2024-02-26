using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clmanipuladorTexto
    {
        public string MyTextPad;
        public string[] MyTextArr;
        public string revertMyTextPad = "";
        public string[] revertMyTextArr;
        public Int32[] ContadorArr;

        public string Inverter(TextBox textBox)
        {
            if(!String.IsNullOrEmpty(textBox.Text)) 
            {
                MyTextPad = textBox.Text;


                for (int i = MyTextPad.Length - 1; i > 0; i--)
                {
                    revertMyTextPad += MyTextPad[i];
                }
            }

            return revertMyTextPad;
        }
      /*  public String[] Inverter(TextBox textBox, Int32 rotand)
        {
            String MyTextTemp = textBox.Text;
            MyTextArr = MyTextTemp.Split(";");

            revertMyTextArr = new String[MyTextArr.Length];


                for (int i = 0; i < revertMyTextArr.Length; i++)
                {
                    revertMyTextArr[i] += MyTextArr[i];
                }

            for (int i = 0; i < revertMyTextArr.Length; i++)
            {
                ContadorArr[i] = new Int32[revertMyTextArr[i].Length];

            }



            for (int i = 0; i < revertMyTextArr.Length; i++)
            {
                MessageBox.Show($"O Array Original: {MyTextArr[i]}\nO Array Invertido: {revertMyTextArr[i]}");
            }

            return revertMyTextArr;
        }*/
    }
}
