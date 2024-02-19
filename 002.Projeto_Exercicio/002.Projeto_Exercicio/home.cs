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
            ToolStripMenuItem Calculos = new ToolStripMenuItem("Cálculos");
            menu.Items.Add(Calculos);
            ToolStripMenuItem Objetos = new ToolStripMenuItem("Objetos");
            menu.Items.Add(Objetos);
            ToolStripMenuItem Financas = new ToolStripMenuItem("Finanças");
            menu.Items.Add(Financas);
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

            ToolStripMenuItem Retangulo = new ToolStripMenuItem("001.002.Retângulo");
            Formas.DropDownItems.Add(Retangulo);
            ToolStripMenuItem Triangulo = new ToolStripMenuItem("001.008.Triângulo");
            Formas.DropDownItems.Add(Triangulo);
            ToolStripMenuItem Circulo = new ToolStripMenuItem("001.005.Círculo");
            Formas.DropDownItems.Add(Circulo);

            ToolStripMenuItem TipoVeiculo = new ToolStripMenuItem("003.009.Tipo de Veículo");
            Veiculo.DropDownItems.Add(TipoVeiculo);
            ToolStripMenuItem Carro = new ToolStripMenuItem("001.007.Carro");
            TipoVeiculo.DropDownItems.Add(Carro);

            ToolStripMenuItem CalcGeometrico = new ToolStripMenuItem("002.005.Cálculo Geométrico");
            Calculos.DropDownItems.Add(CalcGeometrico);
            ToolStripMenuItem CalcUnitario = new ToolStripMenuItem("Cálculo Unitário");
            Calculos.DropDownItems.Add(CalcUnitario);
            ToolStripMenuItem OpMat = new ToolStripMenuItem("002.010.Operações Matemáticas");
            Calculos.DropDownItems.Add(OpMat);
            ToolStripMenuItem Calculadora = new ToolStripMenuItem("002.001.Calculadora");
            Calculos.DropDownItems.Add(Calculadora);
            ToolStripMenuItem Conversor = new ToolStripMenuItem("002.002.Conversor");
            Calculos.DropDownItems.Add(Conversor);
            ToolStripMenuItem Matematica = new ToolStripMenuItem("002.003.Matemática");
            Calculos.DropDownItems.Add(Matematica);

            ToolStripMenuItem Livro = new ToolStripMenuItem("001.004.Livro");
            Objetos.DropDownItems.Add(Livro);
            ToolStripMenuItem TamCam = new ToolStripMenuItem("003.005.Tamanho da Camiseta");
            Objetos.DropDownItems.Add(TamCam);

            ToolStripMenuItem ContaBanc = new ToolStripMenuItem("001.003.Conta Bancária");
            Financas.DropDownItems.Add(ContaBanc);
            ToolStripMenuItem Produto = new ToolStripMenuItem("001.009.Produto");
            Financas.DropDownItems.Add(Produto);
            ToolStripMenuItem Pedido = new ToolStripMenuItem("003.006.Pedido");
            Financas.DropDownItems.Add(Pedido);

            ToolStripMenuItem ManipTexto = new ToolStripMenuItem("002.004.Manipulador de Texto");
            Manipuladores.DropDownItems.Add(ManipTexto);
            ToolStripMenuItem ManipArq = new ToolStripMenuItem("002.007.Manipulador de Arquivos");
            Manipuladores.DropDownItems.Add(ManipArq);
            ToolStripMenuItem ConvUnidade = new ToolStripMenuItem("002.008.Conversor de Unidades");
            Manipuladores.DropDownItems.Add(ConvUnidade);
            ToolStripMenuItem ManipLista = new ToolStripMenuItem("002.009.Manipulador de Lista");
            Manipuladores.DropDownItems.Add(ManipLista);

            ToolStripMenuItem DiasSemana = new ToolStripMenuItem("003.001.Dias da Semana");
            Agenda.DropDownItems.Add(DiasSemana);
            ToolStripMenuItem MesesAno = new ToolStripMenuItem("003.003.Meses do Ano");
            Agenda.DropDownItems.Add(MesesAno);
            ToolStripMenuItem EstacoesAno = new ToolStripMenuItem("003.007.Estações do Ano");
            Agenda.DropDownItems.Add(EstacoesAno);


            Pessoa.Click += PessoaToolStripMenuItem_Click;

            Retangulo.Click += RetanguloToolStringMenuItem_Click;

            ContaBanc.Click += ContaBancToolStringMenuItem_Click;

            return menu;
        }
        private void PessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Frmpessoa pessoa = new Frmpessoa();
            pessoa.ShowDialog();
        }
    
        private void RetanguloToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            FrmRetangulo retangulo = new FrmRetangulo();
            retangulo.ShowDialog();
        }

        private void ContaBancToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanco banco = new FrmBanco();
            banco.ShowDialog();
        }
    }
}
