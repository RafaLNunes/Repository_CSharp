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
    public partial class FrmManipuladorTexto : Form
    {

        clmanipuladorTexto clmt = new clmanipuladorTexto();
        public FrmManipuladorTexto()
        {
            InitializeComponent();
        }

        private void FrmManipuladorTexto_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void EnterArray_Click(object sender, EventArgs e)
        {
            //clmt.Inverter(textarray, 1);
        }

        private void EnterPadrao_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{clmt.Inverter(textpadrao)}");
        }
    }
}
