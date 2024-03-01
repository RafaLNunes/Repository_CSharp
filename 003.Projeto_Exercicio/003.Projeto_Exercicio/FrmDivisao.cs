namespace _003.Projeto_Exercicio
{
    public partial class FrmDivisao : Form
    {
        public FrmDivisao()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.stayhome());
            
            label3.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 v2 = int.Parse(textBox1.Text);
                Int32 v1 = int.Parse(textBox2.Text);

                Int32 value = v2 / v1;
                label3.Visible = true;
                label3.Text = value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
