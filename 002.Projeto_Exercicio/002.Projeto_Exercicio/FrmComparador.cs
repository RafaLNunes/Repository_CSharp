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
    public partial class FrmComparador : Form
    {

        clcomparador comp = new clcomparador();
        public FrmComparador()
        {
            InitializeComponent();
        }

        private void FrmComparador_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comp.Maior(textBox3, textBox4, 0);
        }
    }
}
