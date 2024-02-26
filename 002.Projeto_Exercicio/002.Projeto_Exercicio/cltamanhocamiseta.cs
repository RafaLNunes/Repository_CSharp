using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class cltamanhocamiseta
    {

        public String SeuTam;
        public int tamEscrt;
        public enum TamanhoCamiseta{

            PPA = 63, PPL = 44,
            PA = 66, PL = 46,
            MA = 68, ML = 50,
            GA = 71, GL = 54,
            GGA = 74, GGL = 57,
            GGGA = 80, GGGL = 62,
            GGGGA = 84, GGGGL = 67

        }

        public String tamanho_camiseta(TextBox textBox, TextBox textBox1)
        {
            TamanhoCamiseta tamPPA = TamanhoCamiseta.PPA;
            TamanhoCamiseta tamPPL = TamanhoCamiseta.PPL;
            TamanhoCamiseta tamPA = TamanhoCamiseta.PA;
            TamanhoCamiseta tamPL = TamanhoCamiseta.PL;
            TamanhoCamiseta tamMA = TamanhoCamiseta.MA;
            TamanhoCamiseta tamML = TamanhoCamiseta.ML;
            TamanhoCamiseta tamGA = TamanhoCamiseta.GA;
            TamanhoCamiseta tamGL = TamanhoCamiseta.GL;
            TamanhoCamiseta tamGGA = TamanhoCamiseta.GGA;
            TamanhoCamiseta tamGGL = TamanhoCamiseta.GGL;
            TamanhoCamiseta tamGGGA = TamanhoCamiseta.GGGA;
            TamanhoCamiseta tamGGGL = TamanhoCamiseta.GGGL;
            TamanhoCamiseta tamGGGGA = TamanhoCamiseta.GGGGA;
            TamanhoCamiseta tamGGGGL = TamanhoCamiseta.GGGGL;

            tamEscrt = Convert.ToInt32(textBox.Text);
            if (tamEscrt < (int)TamanhoCamiseta.GL)
            {

            }


            return SeuTam;
        }

    }
}
