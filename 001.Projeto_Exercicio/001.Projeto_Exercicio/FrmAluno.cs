using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _001.Projeto_Exercicio
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

    }
}
/*

using System;
using System.Windows.Forms;

namespace MeuProjeto
{
    public partial class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            InitializeComponent();
        }

        private void buttonEsconderTextBox_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}

using System;
using System.Windows.Forms;

namespace MeuProjeto
{
    public partial class MeuFormulario : Form
    {
        public MeuFormulario()
        {
            InitializeComponent();
        }

        private void buttonEsconderTodosOsItens_Click(object sender, EventArgs e)
        {
            EsconderControles(this);
        }

        private void EsconderControles(Control control)
        {
            foreach (Control controlChild in control.Controls)
            {
                controlChild.Visible = false;
                EsconderControles(controlChild);
            }
        }
    }
}

*/