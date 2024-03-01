using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clpedido
    {
        public String status_do_Pedido = "";
        public enum StatusPedido
        {
            Novo = 0,
            Processando = 1,
            Enviado = 2,
            Entregue = 3,
        }

        public String Status()
        {



            return status_do_Pedido;
        }

    }
}
