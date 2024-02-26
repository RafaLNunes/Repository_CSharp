using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _002.Projeto_Exercicio
{
    public partial class FrmManipuladorLista : Form
    {

        clmanipuladorlista clml = new clmanipuladorlista();
        public FrmManipuladorLista()
        {
            InitializeComponent();
        }

        private void FrmManipuladorLista_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clml.RemoverElemento(textBox1, textBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clml.RemoverElemento(textBox2);
        }
    }
}
