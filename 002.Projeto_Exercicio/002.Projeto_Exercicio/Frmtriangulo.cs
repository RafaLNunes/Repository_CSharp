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
    public partial class Frmtriangulo : Form
    {
        public Frmtriangulo()
        {
            InitializeComponent();
        }

        private void Frmtriangulo_Load(object sender, EventArgs e)
        {
            home hm = new home();
            hm.vemhome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cltriangulo tri = new cltriangulo();
            MessageBox.Show($"O perimetro desse triangulo apresentado é: {tri.Perimetro(textA, textB, textC)}");
        }
    }
}
