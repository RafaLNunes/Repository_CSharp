using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcarro
    {
        public String[] Marca = new String[5] {"mac1", "mac2", "mac3", "mac4", "mac5"};
        public String[] Modelo = new String[5] {"Car1", "Car2", "Car3", "Car4", "Car5" };

        public String[] cnc = new String[5];

        public void concatenar()
        {
            for (int i = 0; i < Marca.Length; i++)
            {
                MessageBox.Show($"A marca é: {Marca[i]}\nO modelo é: {Modelo[i]}");
            }
        }
    }
}
