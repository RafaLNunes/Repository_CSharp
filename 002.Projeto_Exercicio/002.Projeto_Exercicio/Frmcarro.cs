using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002.Projeto_Exercicio
{
    public partial class Frmcarro : Form
    {
        String[] marca = {"fiat"};
        String[] modelo = { "uno" };
        Int32 cont = 0;
        public Frmcarro()
        {
            InitializeComponent();
        }

        private void Frmcarro_Load(object sender, EventArgs e)
        {
            clcarro carro = new clcarro();
            carro.concatenar();

            home hm = new home();
            hm.vemhome();

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
