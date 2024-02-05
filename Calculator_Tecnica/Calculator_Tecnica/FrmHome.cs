using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Tecnica
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Calculator = new Form1();
            Calculator.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser usuario = new FrmUser();
            usuario.ShowDialog();
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTextos Area_Textos = new FrmTextos();
            Area_Textos.ShowDialog();
            
            
        }
    }
}
