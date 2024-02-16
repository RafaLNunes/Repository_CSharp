using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clpessoa
    {
        public String nome;
        public Int32 idade;

        public void apresentar()
        {
            MessageBox.Show("Seu nome: " + nome + "\nSua idade: " + idade);
        }

    }
}
