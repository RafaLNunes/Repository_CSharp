using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002.Projeto_Exercicio
{
    public partial class FrmBanco : Form
    {
        public FrmBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {

            home hm = new home();
            this.Controls.Add(hm.vemhome());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            clbanco banco = new clbanco();
            banco.Cot_cont(textBox1, 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clbanco banco = new clbanco();
            banco.Cot_cont(textBox1, 1);
        }
    }
}
