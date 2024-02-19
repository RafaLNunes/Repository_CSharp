using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class cllivro
    {

        public String titulo;
        public String autor;
        public String ap; //dia //mes //ano 
        public Int32 edicao;
    public string Add_book(TextBox textBox, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5)
        {
            titulo = textBox.Text;
            autor = textBox1.Text;
            ap = textBox2.Text + "/" + textBox3.Text + "/" + textBox4.Text;
            edicao = Convert.ToInt32(textBox5.Text);


            return titulo;
        }
    }
}
