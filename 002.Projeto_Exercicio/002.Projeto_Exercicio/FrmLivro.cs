﻿using System;
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
    public partial class FrmLivro : Form
    {
        public FrmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            home hm = new home();
            this.Controls.Add(hm.vemhome());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cllivro livro = new cllivro();
            MessageBox.Show("Livro: "+livro.Add_book(textttulo, textautor, textdia, textmes, textano, textedicao)+"\nAutor:"+livro.autor+"\nData de Publicação: "+livro.ap+"\nEdição: "+livro.edicao);
        }
    }
}
