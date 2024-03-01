using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003.Projeto_Exercicio
{
    internal class home
    {
        public MenuStrip stayhome()
        {

            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem Divisao = new ToolStripMenuItem("Divisão");
            menu.Items.Add(Divisao);
            ToolStripMenuItem Calculadora = new ToolStripMenuItem("Calculadora");
            menu.Items.Add(Calculadora);

            Divisao.Click += DivisaoToolStripMenuItem_Click;
            Calculadora.Click += CalculadoraToolStripMenuItem_Click;

            return menu;
        }

        private void DivisaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivisao Frm = new FrmDivisao();
            Frm.ShowDialog();
        }
        private void CalculadoraToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            FrmCalculadora Frm = new FrmCalculadora();
            Frm.ShowDialog();
        }
    }
}
