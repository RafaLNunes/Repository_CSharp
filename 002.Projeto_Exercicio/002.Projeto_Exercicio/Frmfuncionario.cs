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
    public partial class Frmfuncionario : Form
    {

        clfuncionario func = new clfuncionario();
        public Frmfuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func.SalarioAnual(textBox1, textBox2);
            func.SalarioAnual();
            func.SalarioAnual(13);
            MessageBox.Show($"Seu Nome: {func.nome}\nSeu salario: {func.salario}\nSeu Salario Anual: {func.sal_inter}\nSeu salario com desconto de Imposto: {func.sal_desc}\nSeu Salario Anual com 13°: {func.sal_13}");
        }

        private void Frmfuncionario_Load(object sender, EventArgs e)
        {
            home hm = new home();
            hm.vemhome();
        }
    }
}
