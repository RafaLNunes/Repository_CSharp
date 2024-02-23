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
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            claluno aluno = new claluno();
            aluno.media(textBox1, textBox2, textBox3, textBox4, textBox5, textBox6);

            MessageBox.Show($"Sua média é: {aluno.Entre_Nota()}");
        }
    }
}
