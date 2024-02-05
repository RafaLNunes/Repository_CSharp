using System.Threading.Tasks.Sources;

namespace Projeto_CSharp
{
    public partial class Form1 : Form
    {

        Int32 sum;
        Int32 value2;
        Int32 value1;
        Double value3;
        Double value4;
        Double raiz;
        Double pot;
        Int32 check;

        private void button25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ola Ciratuba!!!!!");
        }

        void CheckNumber()
        {
            if (textBox3.Text == "÷" || textBox3.Text == "=" || textBox3.Text == "Deletado" || textBox3.Text == "X" || textBox3.Text == "-" || textBox3.Text == "+")
            {
                textBox3.Text = "";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (check)
            {
                case 1:
                    textBox4.Text = ("Result: " + sum.ToString());
                    break;
                case 2:
                    textBox4.Text = ("Result: " + raiz.ToString());
                    break;
                case 3:
                    textBox4.Text = ("Result: " + pot.ToString());
                    break;
            }



        }

        private void button15_Click(object sender, EventArgs e)
        {

            textBox3.Text = "÷";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CheckNumber();
            textBox3.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text = "=";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Deletado";
            value3 = 0;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text = "X";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox3.Text);
            textBox3.Text = "+ ";
        }


        private void button21_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            value2 = Convert.ToInt32(textBox2.Text);
            check = 1;
            sum = value1 / value2;


        }

        private void button20_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            value2 = Convert.ToInt32(textBox2.Text);
            check = 1;
            sum = value1 * value2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            value2 = Convert.ToInt32(textBox2.Text);
            check = 1;
            sum = value1 - value2;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            value1 = Convert.ToInt32(textBox1.Text);
            value2 = Convert.ToInt32(textBox2.Text);

            check = 1;
            sum = value1 + value2;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            value3 = Convert.ToDouble(textBox1.Text);
            value4 = Convert.ToDouble(textBox2.Text);
            check = 3;
            pot = Math.Pow(value3, value4);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            value3 = Convert.ToDouble(textBox1.Text);
            check = 2;
            raiz = Math.Sqrt(value3);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
