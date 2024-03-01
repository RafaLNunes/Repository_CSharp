using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class cltipveiculo
    {

        public enum tiposveiculos
        {
            Carro = 2, Moto = 3, Caminhao = 7, returna = 10
        }

        public tiposveiculos tipos(TextBox textBox)
        {
            int numb = int.Parse(textBox.Text);

            tiposveiculos tpc = tiposveiculos.Carro;
            tiposveiculos tpm = tiposveiculos.Moto;
            tiposveiculos tpc2 = tiposveiculos.Caminhao;
            tiposveiculos defulte = tiposveiculos.returna;

            int tip = 0;

            if (numb % 2 == 0) {
                tip = 2;
            }else if (numb % 3 == 0)
            {
                tip = 3;
            }else if(numb % 7 == 0) {
                tip = 7;
            }

            switch (tip)
            {
                case 2:
                    defulte = tpc; break;
                case 3: 
                    defulte = tpm; break;
                case 4:
                    defulte = tpc2; break;
                default:
                    defulte = tiposveiculos.returna;
                    break;

            }


            return defulte;
        }
    }
}
