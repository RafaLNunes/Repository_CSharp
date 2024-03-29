﻿using System;
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
            pictureBox1.Visible = true;


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

        Double grade1;
        Double grade2;
        Double grade3;
        Double grade4;
        Double media;
        Double prese;
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

            grade1 = Convert.ToDouble(textBox3.Text);
            grade2 = Convert.ToDouble(textBox4.Text);
            grade3 = Convert.ToDouble(textBox5.Text);
            grade4 = Convert.ToDouble(textBox6.Text);
            media = grade1 + grade2 + grade3 + grade4;
            media = media / 4;


            prese = Convert.ToDouble(textBox7.Text);

            prese /= 200;
            prese *= 100;


            label4.Text = media + "\nAnd Your presence:\n" + prese;

            if (prese < 140 || media < 75) {
                label4.Text += "\nyou are recovering";
            }if(prese < 140)
            {
                label4.Text += "\nyour presence was not enough";
            }if(media < 75)
            {
                label4.Text += "\nyour average was not good enough";
            }
            else
            {
                label4.Text += "\nyou're a winner!!\nyou passed the grade";
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentral home = new FrmCentral();
            home.ShowDialog();
        }

        private void médiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno aluno = new FrmAluno();
            aluno.ShowDialog();
        }

        private void bhaskaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBhaskara bhk = new FrmBhaskara();
            bhk.ShowDialog();
        }

        private void comJurosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestacao prestacao = new FrmPrestacao();
            prestacao.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
