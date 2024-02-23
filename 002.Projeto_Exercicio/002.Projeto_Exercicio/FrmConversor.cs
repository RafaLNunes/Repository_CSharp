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
    public partial class FrmConversor : Form
    {
        clconversor cnv = new clconversor();

        public FrmConversor()
        {
            InitializeComponent();
        }

        private void FrmConversor_Load(object sender, EventArgs e)
        {
            home hm = new home();
            hm.vemhome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textDr.Text = cnv.Converter(textDr).ToString();
            cnv.Converter(textRv, textRr);
        }
    }
}
