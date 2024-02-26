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
    public partial class frmCalculadoraGeometrica : Form
    {

        clcalculadorageometrica clcg = new clcalculadorageometrica();
        public frmCalculadoraGeometrica()
        {
            InitializeComponent();
        }

        private void frmCalculadoraGeometrica_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void cir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A área do círculo apresentado é: {clcg.CalcularArea(textraio)}");
        }

        private void Tri_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A área do triângulo apresentado é: {clcg.CalcularArea(textbase, textalt)}");
        }

        private void ret_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A área do retângulo apresentado é: {clcg.CalcularArea(textlargura, textalt)}");
        }
    }
}
