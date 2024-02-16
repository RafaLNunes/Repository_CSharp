using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _002.Projeto_Exercicio
{
    internal class home
    {
        public home()
        {
        }
        public MenuStrip vemhome()
        {
            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem Humano = new ToolStripMenuItem("Humano");
            menu.Items.Add(Humano);
            ToolStripMenuItem Formas = new ToolStripMenuItem("Formas");
            menu.Items.Add(Formas);
            ToolStripMenuItem Veiculo = new ToolStripMenuItem("Veículo");
            menu.Items.Add(Veiculo);
            ToolStripMenuItem Cálculos = new ToolStripMenuItem("Cálculos");
            menu.Items.Add(Cálculos);
            ToolStripMenuItem Objetos = new ToolStripMenuItem("Objetos");
            menu.Items.Add(Objetos);
            ToolStripMenuItem Finanças = new ToolStripMenuItem("Finanças");
            menu.Items.Add(Finanças);
            ToolStripMenuItem Manipuladores = new ToolStripMenuItem("Manipuladores");
            menu.Items.Add(Manipuladores);
            ToolStripMenuItem Agenda = new ToolStripMenuItem("Agenda");
            menu.Items.Add(Agenda);

            ToolStripMenuItem Pessoa = new ToolStripMenuItem("001.001.Pessoa");
            Humano.DropDownItems.Add(Pessoa);
            ToolStripMenuItem Aluno = new ToolStripMenuItem("001.006.Aluno");
            Humano.DropDownItems.Add(Aluno);
            ToolStripMenuItem Funcionário = new ToolStripMenuItem("001.010.Funcionário");
            Humano.DropDownItems.Add(Funcionário);
            ToolStripMenuItem Comprador = new ToolStripMenuItem("002.006.Comprador");
            Humano.DropDownItems.Add(Comprador);

            ToolStripMenuItem Retângulo = new ToolStripMenuItem("001.002.Retângulo");
            Formas.DropDownItems.Add(Retângulo);
            ToolStripMenuItem Triângulo = new ToolStripMenuItem("001.008.Triângulo");
            Formas.DropDownItems.Add(Triângulo);
            ToolStripMenuItem Círculo = new ToolStripMenuItem("001.005.Círculo");
            Formas.DropDownItems.Add(Círculo);

            ToolStripMenuItem TipoVeículo = new ToolStripMenuItem("003.009.Tipo de Veículo");
            Veiculo.DropDownItems.Add(TipoVeículo);
            ToolStripMenuItem Carro = new ToolStripMenuItem("001.007.Carro");
            TipoVeículo.DropDownItems.Add(Carro);

            ToolStripMenuItem CalcGeometrico = new ToolStripMenuItem("002.005.Cálculo Geométrico");
            Cálculos.DropDownItems.Add(CalcGeometrico);
            ToolStripMenuItem CalcUnitário = new ToolStripMenuItem("Cálculo Unitário");
            Cálculos.DropDownItems.Add(CalcUnitário);
            ToolStripMenuItem OpMat = new ToolStripMenuItem("002.010.Operações Matemáticas");
            Cálculos.DropDownItems.Add(OpMat);
            ToolStripMenuItem Calculadora = new ToolStripMenuItem("002.001.Calculadora");
            Cálculos.DropDownItems.Add(Calculadora);
            ToolStripMenuItem Conversor = new ToolStripMenuItem("002.002.Conversor");
            Cálculos.DropDownItems.Add(Conversor);
            ToolStripMenuItem Matemática = new ToolStripMenuItem("002.003.Matemática");
            Cálculos.DropDownItems.Add(Matemática);

            ToolStripMenuItem Livro = new ToolStripMenuItem("001.004.Livro");
            Objetos.DropDownItems.Add(Livro);
            ToolStripMenuItem TamCam = new ToolStripMenuItem("003.005.Tamanho da Camiseta");
            Objetos.DropDownItems.Add(TamCam);

            ToolStripMenuItem ContaBanc = new ToolStripMenuItem("001.003.Conta Bancária");
            Objetos.DropDownItems.Add(ContaBanc);
            ToolStripMenuItem Produto = new ToolStripMenuItem("001.009.Produto");
            Objetos.DropDownItems.Add(Produto);
            ToolStripMenuItem Pedido = new ToolStripMenuItem("003.006.Pedido");
            Objetos.DropDownItems.Add(Pedido);

            ToolStripMenuItem ManipTexto = new ToolStripMenuItem("002.004.Manipulador de Texto");
            Objetos.DropDownItems.Add(ManipTexto);
            ToolStripMenuItem ManipArq = new ToolStripMenuItem("002.007.Manipulador de Arquivos");
            Objetos.DropDownItems.Add(ManipArq);
            ToolStripMenuItem ConvUnidade = new ToolStripMenuItem("002.008.Conversor de Unidades");
            Objetos.DropDownItems.Add(ConvUnidade);
            ToolStripMenuItem ManipLista = new ToolStripMenuItem("002.009.Manipulador de Lista");
            Objetos.DropDownItems.Add(ManipLista);

            ToolStripMenuItem DiasSemana = new ToolStripMenuItem("003.001.Dias da Semana");
            Objetos.DropDownItems.Add(DiasSemana);
            ToolStripMenuItem MesesAno = new ToolStripMenuItem("003.003.Meses do Ano");
            Objetos.DropDownItems.Add(MesesAno);
            ToolStripMenuItem EstacoesAno = new ToolStripMenuItem("003.007.Estações do Ano");
            Objetos.DropDownItems.Add(EstacoesAno);

            Pessoa.Click += PessoaToolStripMenuItem_Click;

            return menu;
        }
        private void PessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frmpessoa pessoa = new Frmpessoa();
            pessoa.ShowDialog();
        }
    }
}
