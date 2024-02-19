using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _002.Projeto_Exercicio
{
    internal class clretangulo
    {

        Double larg;
        Double alt;
        Double area_resut;
        public String calc_area(Label label, TextBox textBox, TextBox textBox1)
        {

            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text))
            {
                larg = Convert.ToDouble(textBox.Text);
                alt = Convert.ToDouble(textBox1.Text);

                area_resut = larg * alt;                
            }

            return area_resut.ToString();

        }
    }
}
