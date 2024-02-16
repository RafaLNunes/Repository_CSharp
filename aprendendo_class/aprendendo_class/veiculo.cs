using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class veiculo
    {
        public String chassi;
        private String modelo;
        protected String placa;

        public veiculo()
        {
            placa = "BAX2R36";
            modelo = "";

        }
        public String setPlaca()
        {
            placa = "EWL4D24";
            return placa;
        }
    }
}