using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clmanipuladorTexto
    {
        public string txt = "Olá, Mundo";
        public string txtreverse = "";

        public string Inverter()
        {
            for (int i = txt.Length - 1; i > 0; i--)
            {
                txtreverse += txt[i];
            }

            return txtreverse;
        }
    }
}
