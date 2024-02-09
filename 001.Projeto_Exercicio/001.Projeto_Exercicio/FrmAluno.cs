using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox4.ForeColor = Color.Gray;
            textBox5.ForeColor = Color.Gray;
            textBox6.ForeColor = Color.Gray;
            textBox7.ForeColor = Color.Gray;


            textBox1.Text = "log in with your name";
            textBox2.Text = "Enter as your school unit";
            textBox3.Text = "Enter your first note";
            textBox4.Text = "Enter your second note";
            textBox5.Text = "Enter your third note";
            textBox6.Text = "Enter your fourth note";
            textBox7.Text = "Enter the number of classes attended";
        }
        String name;

        float[] grade = new float[4];
        float media;
        float prese;
        void marck(String MyText, TextBox textBox)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            marck("log in with your name", textBox1);
            if (textBox1.Text != "log in with your name")
            {
                name = textBox1.Text;
                label2.Text = name;
            }
            else
            {
                name = "";
                label2.Text = "";
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            marck("Enter as your school unit", textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            marck("Enter your first note", textBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            marck("Enter your second note", textBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            marck("Enter your third note", textBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            marck("Enter your fourth note", textBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            marck("Enter the number of classes attended", textBox7);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text) || String.IsNullOrEmpty(textBox6.Text) || String.IsNullOrEmpty(textBox7.Text))
            {
                grade[0] = (float)Convert.ToDouble(textBox3.Text);
                grade[1] = (float)Convert.ToDouble(textBox4.Text);
                grade[2] = (float)Convert.ToDouble(textBox5.Text);
                grade[3] = (float)Convert.ToDouble(textBox6.Text);
                for (int i = 0; i < 4; i++)
                {
                    media += grade[i];
                }
                media = media / 4;


                prese = (float)Convert.ToDouble(textBox7.Text);

                prese /= 200;
                prese *= 100;
                if (prese < 75)
                {
                    pictureBox2.Visible = true;
                    pictureBox1.Visible = false;
                }
                else
                {
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                }
            }
            else
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Focus();
                }
                else if (String.IsNullOrEmpty(textBox2.Text))
                {
                    textBox2.Focus();
                }
                else if (String.IsNullOrEmpty(textBox3.Text))
                {
                    textBox3.Focus();
                }
                else if (String.IsNullOrEmpty(textBox4.Text))
                {
                    textBox4.Focus();
                }
                else if (String.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.Focus();
                }
                else if (String.IsNullOrEmpty(textBox6.Text))
                {
                    textBox6.Focus();
                }
                else if (String.IsNullOrEmpty(textBox7.Text)) { textBox6.Focus(); }

            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Check ok
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //check off
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bhaskaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBhaskara bhaskara = new FrmBhaskara();
            bhaskara.ShowDialog();
        }

        private void comJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestacao prestacao = new FrmPrestacao();
            prestacao.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentral home = new FrmCentral();
            home.ShowDialog();
        }
    }
}
