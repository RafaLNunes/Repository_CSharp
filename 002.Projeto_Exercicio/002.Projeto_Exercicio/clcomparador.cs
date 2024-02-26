using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class clcomparador
    {
        public Int32 Maior_int;
        public Double Maior_dec;
        public Int32 Maior(Int32 numb1, Int32 numb2)
        {


            if (numb1 > numb2)
            {
                Maior_int = numb1;
            }
            else if (numb2 > numb1)
            {
                Maior_int = numb2;
            }

            return Maior_int;
        }
        public Double Maior(Double numb1, Double numb2, Double vasco)
        {
            if (numb1 > numb2)
            {
                Maior_dec = numb1;
            }
            else if (numb2 > numb1)
            {
                Maior_dec = numb2;
            }

            return Maior_dec;
        }

    }
}
