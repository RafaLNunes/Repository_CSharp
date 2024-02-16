using _002.Projeto_Exercicio;

namespace aprendendo_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                veiculo v1 = new veiculo();
                v1.chassi = "14567876543";
                MessageBox.Show("Placa: " + v1.setPlaca() + "\nChassi: " + v1.chassi);


    
        }
    }
}
