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
    public partial class frmcirculo : Form
    {
        public frmcirculo()
        {
            InitializeComponent();
        }

        private void frmcirculo_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clcirculo circulo = new clcirculo();
            MessageBox.Show($"O Diametro do seu circulo é: {circulo.diametro(textBox1)}\nE o raio o do seu circulo é {circulo.raio}");
        }
    }
}
