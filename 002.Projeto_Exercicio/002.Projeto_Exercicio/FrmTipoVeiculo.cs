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
    public partial class FrmTipoVeiculo : Form
    {
        public FrmTipoVeiculo()
        {
            InitializeComponent();
        }

        private void FrmTipoVeiculo_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cltipveiculo tip = new cltipveiculo();
            MessageBox.Show($"Seu veiculo: {tip.tipos(textBox1)}");
        }
    }
}
