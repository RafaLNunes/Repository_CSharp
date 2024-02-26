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
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clcalculadora calc = new clcalculadora();
            MessageBox.Show($"A soma dos Números Inteiros: {calc.Somar(3, textBox1, textBox4)}");
            MessageBox.Show($"A soma do Número Decimal: {calc.Somar(textBox2, textBox3)}");
        }
    }
}
