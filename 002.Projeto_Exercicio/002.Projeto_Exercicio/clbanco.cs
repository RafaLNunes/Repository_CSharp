using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clbanco
    {
        public Double saldo = 0;
        public Double limite = 0;
        Double deposito = 0;
        Double sacar = 0;
        public Double cot_limit(Double limit, TextBox textBox)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                saldo = Convert.ToDouble(textBox.Text);
                limite = limit;
                MessageBox.Show("Seu Limite atual é de: " + limite + "\nSeu Saldo Atua é: " + saldo);
                FrmBanco banco = new FrmBanco();
                banco.ShowDialog();
            }

            return saldo;
        }

        public object Cot_cont(TextBox textBox, Int32 vercao)
        {
            if (!String.IsNullOrEmpty(textBox.Text))
            {
                //deposito
                if (vercao == 1)
                {
                    deposito = Convert.ToDouble(textBox.Text);
                    saldo += deposito;
                }
                //Sacar
                else if (vercao == 2)
                {
                    sacar = Convert.ToDouble(textBox.Text);
                    if (sacar > saldo)
                    {
                        sacar -= saldo;
                        saldo = 0;
                        limite -= sacar;
                        limite *= -1;
                        MessageBox.Show("esse saque ultrapassou seu saldo, parte do seu limite vai ser usado");
                        MessageBox.Show($"O seu limite atual é de: {limite}");
                    }
                }
                else
                {
                    textBox.Focus();
                }


                
            }
            return saldo;
        }
    }
}
