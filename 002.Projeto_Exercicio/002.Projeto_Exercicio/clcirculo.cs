using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcirculo
    {
        public Double raio;
        public Double diametro(TextBox textBox)
        {
            Double resut_diametro;

            raio = Convert.ToDouble(textBox.Text);

            resut_diametro = 2 * raio;

            return resut_diametro;
        }
    }
}
