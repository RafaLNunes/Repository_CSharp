using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clfuncionario
    {

        public String nome;
        public Double salario;
        public Double sal_inter;
        public Double sal_desc;
        public Double sal_13;

        public Double SalarioAnual(TextBox textBox, TextBox textBox1)
        {

            if (!String.IsNullOrEmpty(textBox.Text) && !String.IsNullOrEmpty(textBox1.Text))
            {
                nome = textBox.Text;
                salario = Convert.ToDouble(textBox1.Text);

                sal_inter = salario * 12;

                sal_inter.ToString("F2");
            }
            else
            {
                textBox.Focus();
            }
            return sal_inter;
        }
        public Double SalarioAnual()
        {
            Double desc = 0.30;
            sal_desc = (sal_desc * 12);
            Double sal_desck = sal_desc;
            sal_desc = sal_desc-(sal_desck * desc);

            return sal_desc;
        }
        public Double SalarioAnual(Int32 v1) 
        {
            sal_inter *= v1;

            return sal_13;
        }

    }
}
