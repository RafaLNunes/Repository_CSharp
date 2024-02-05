namespace Calculator_Tecnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        void bhaskara()
        {
            Double valueX = (float)Convert.ToDouble(textBox1.Text);
            Double valueY = (float)Convert.ToDouble(textBox2.Text);
            Double valueZ = (float)Convert.ToDouble(textBox3.Text);

            Double BKN = (-valueY - Math.Sqrt(Math.Pow(valueY, 2) - 4 * valueX * valueZ)) / (2 * valueX);
            Double BKP = (-valueY + Math.Sqrt(Math.Pow(valueY, 2) - 4 * valueX * valueZ)) / (2 * valueX);

            MessageBox.Show(BKP + "\n" + BKN);
        }



        void focuseds()
        {
            if (textBox1.ContainsFocus)
            {
                textBox1.KeyDown += (sender, e) =>
                {
                    if (textBox1.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox2.Focus();
                    }
                };
            }
            if (textBox2.ContainsFocus)
            {
                textBox2.KeyDown += (sender, e) =>
                {
                    if (textBox2.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox3.Focus();
                    }
                };
            }
            if (textBox3.ContainsFocus)
            {
                textBox3.KeyDown += (sender, e) =>
                {
                    if (textBox3.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox1.Focus();
                    }
                };
            }
        }

        void WaterMark(String MyText, TextBox textBox)
        {
            textBox.Paint += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == MyText)
                {
                    textBox.Clear();
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox1.Text = "Enter the your first Number...";
            textBox2.Text = "Enter the your Second Number...";
            textBox3.Text = "Enter the your third Number...";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            focuseds();
            WaterMark("Enter the your first Number...", textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            focuseds();
            WaterMark("Enter the your Second Number...", textBox2);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            focuseds();
            WaterMark("Enter the your third Number...", textBox3);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bhaskara();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.ShowDialog();
        }
    }
}
