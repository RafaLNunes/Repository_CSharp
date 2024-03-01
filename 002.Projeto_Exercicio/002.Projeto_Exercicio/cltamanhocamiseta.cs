using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class cltamanhocamiseta
    {

        public String SeuTam = "";
        public int tamAEscrt;
        public int tamLEscrt;
        public String P = "Pequeno";
        public String M = "Médio";
        public String G = "Grande";
        public String X = "Fora dos Tamanhso de nossa Loja";

        public String SPP = "2P";
        public String SP = "P";
        public String SM = "M";
        public String SG = "G";
        public String SGG = "2G";
        public String SGGG = "3G";
        public String SGGGG = "4G";
        public enum TamanhoCamiseta{

            PPA = 63, PPL = 44,
            PA = 66, PL = 46,
            MA = 68, ML = 50,
            GA = 71, GL = 54,
            GGA = 74, GGL = 57,
            GGGA = 80, GGGL = 62,
            GGGGA = 84, GGGGL = 67

        }
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
        public String tamanho_camiseta(TextBox textBox/*Altura*/, TextBox textBox1/*Largura*/)
        {
            tamAEscrt = Convert.ToInt32(textBox.Text);
            tamLEscrt = Convert.ToInt32(textBox1.Text);

            // SeuTam = $"Seu Tamanho: {P}\nSua medida de Altura é equivalente a: {SPP}\nSua medida de Largura é equivalente a: {SPP}";

            if(tamAEscrt <= (int)tamPPA && tamLEscrt <=(int)tamPPL)
            {
                SeuTam = $"Seu Tamanho: {P}\nSua medida de Altura é equivalente a: {SPP}\nSua medida de Largura é equivalente a: {SPP}";
            }
            else if(tamAEscrt > (int)tamPPA && tamLEscrt > (int)tamPPL && tamAEscrt <= (int)tamPA && tamLEscrt <= (int)tamPL)
            {
                SeuTam = $"Seu Tamanho: {P}\nSua medida de Altura é equivalente a: {SP}\nSua medida de Largura é equivalente a: {SP}";
            }
            else if (tamAEscrt > (int)tamPA && tamLEscrt > (int)tamPL && tamAEscrt <= (int)tamMA && tamLEscrt <= (int)tamML)
            {
                SeuTam = $"Seu Tamanho: {M}\nSua medida de Altura é equivalente a: {SM}\nSua medida de Largura é equivalente a: {SM}";
            }
            else if (tamAEscrt > (int)tamMA && tamLEscrt > (int)tamML && tamAEscrt <= (int)tamGA && tamLEscrt <= (int)tamGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SG}\nSua medida de Largura é equivalente a: {SG}";
            }
            else if (tamAEscrt > (int)tamMA && tamLEscrt > (int)tamML && tamAEscrt <= (int)tamGA && tamLEscrt <= (int)tamGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SG}\nSua medida de Largura é equivalente a: {SG}";
            }
            else if (tamAEscrt > (int)tamGA && tamLEscrt > (int)tamGL && tamAEscrt <= (int)tamGGA && tamLEscrt <= (int)tamGGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SGG}\nSua medida de Largura é equivalente a: {SGG}";
            }
            else if (tamAEscrt > (int)tamGGA && tamLEscrt > (int)tamGGL && tamAEscrt <= (int)tamGGGA && tamLEscrt <= (int)tamGGGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SGGG}\nSua medida de Largura é equivalente a: {SGGG}";
            }
            else if (tamAEscrt > (int)tamGGGA && tamLEscrt > (int)tamGGGL && tamAEscrt <= (int)tamGGGGA && tamLEscrt <= (int)tamGGGGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SGGGG}\nSua medida de Largura é equivalente a: {SGGGG}";
            }
            else if (tamAEscrt > (int)tamGGGA && tamLEscrt > (int)tamGGGL && tamAEscrt <= (int)tamGGGGA && tamLEscrt <= (int)tamGGGGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {SGGGG}\nSua medida de Largura é equivalente a: {SGGGG}";
            }
            else if (tamAEscrt > (int)tamGGGA && tamLEscrt > (int)tamGGGL)
            {
                SeuTam = $"Seu Tamanho: {G}\nSua medida de Altura é equivalente a: {X}\nSua medida de Largura é equivalente a: {X}";
            }
            return SeuTam;
        }

    }
}
