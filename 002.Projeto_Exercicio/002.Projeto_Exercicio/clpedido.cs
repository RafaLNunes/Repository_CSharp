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

        public String Status(TextBox textBox)
            
        {
            String stat = textBox.Text;

            for (int i = 0; i <= 3; i++)
            {
                if (Enum.IsDefined(typeof(StatusPedido), i))
                {
                    StatusPedido status = (StatusPedido)i;
                    MessageBox.Show($"O pedido: {stat}\nStatus do Pedido:{status}");
                }
            }

            return status_do_Pedido;
            
        }

    }
}
