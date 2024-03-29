﻿using System;
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
            ToolStripMenuItem Comparador = new ToolStripMenuItem("002.006.Comparador");
            Calculos.DropDownItems.Add(Comparador);

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
            Livro.Click += LivroToolStringMenuItem_Click;
            Circulo.Click += CirculoToolStringMenuItem_Click;
            Aluno.Click += AlunoloToolStringMenuItem_Click;
            Carro.Click += CarroToolStringMenuItem_Click;
            Triangulo.Click += TrianguloToolStringMenuItem_Click;
            Produto.Click += ProdutoToolStringMenuItem_Click;
            Funcionário.Click += FuncionárioToolStringMenuItem_Click;
            Calculadora.Click += CalculadoraToolStringMenuItem_Click;
            Conversor.Click += ConversorToolStringMenuItem_Click;
            ManipTexto.Click += ManipTextoToolStringMenuItem_Click;
            Matematica.Click += MatematicaToolStringMenuItem_Click;
            CalcGeometrico.Click += CalcGeometricoToolStringMenuItem_Click;
            Comparador.Click += ComparadorToolStringMenuItem_Click;
            ManipLista.Click += ManipListaToolStringMenuItem_Click;
            TamCam.Click += TamCamToolStringMenuItem_Click;
            Pedido.Click += PedidoToolStringMenuItem_Click;
            TipoVeiculo.Click += TipoVeiculoToolStringMenuItem_Click;

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
            FrmAberturabanco banco = new FrmAberturabanco();
            banco.ShowDialog();
        }
        private void LivroToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmLivro livro = new FrmLivro();
            livro.ShowDialog();
        }
        private void CirculoToolStringMenuItem_Click(object sender, EventArgs e)
        {
            frmcirculo circulo = new frmcirculo();
            circulo.ShowDialog();
        }

        private void AlunoloToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno aluno = new FrmAluno();
            aluno.ShowDialog();
        }

        private void CarroToolStringMenuItem_Click(object sender, EventArgs e)
        {
            Frmcarro carro = new Frmcarro();
            carro.ShowDialog();
        }
        private void TrianguloToolStringMenuItem_Click(object sender, EventArgs e)
        {
            Frmtriangulo tri = new Frmtriangulo();
            tri.ShowDialog();
        }

        private void ProdutoToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            Frmproduto prod = new Frmproduto();
            prod.ShowDialog();
        }
        private void FuncionárioToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            Frmfuncionario func = new Frmfuncionario();
            func.ShowDialog();
        }

        private void CalculadoraToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculadora calc = new FrmCalculadora();
            calc.ShowDialog();
        }

        private void ConversorToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmConversor convt = new FrmConversor();
            convt.ShowDialog();
        }

        private void ManipTextoToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmManipuladorTexto frmt = new FrmManipuladorTexto();
            frmt.ShowDialog();
        }

        private void MatematicaToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatematica mat = new FrmMatematica();
            mat.ShowDialog();
        }
        private void CalcGeometricoToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            frmCalculadoraGeometrica clcg = new frmCalculadoraGeometrica();
            clcg.ShowDialog();
        }
        private void ComparadorToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            FrmComparador comp = new FrmComparador();
            comp.ShowDialog();
        }
        private void ManipListaToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            FrmManipuladorLista Frmml = new FrmManipuladorLista();
            Frmml.ShowDialog();
        }
        private void TamCamToolStringMenuItem_Click(Object sender, EventArgs e){
            FrmTamanhoCamiseta tc = new FrmTamanhoCamiseta();
            tc.ShowDialog();
        }

        private void PedidoToolStringMenuItem_Click(Object sender, EventArgs e)
        {
            FrmPedido ped = new FrmPedido();
            ped.ShowDialog();
        }
        private void TipoVeiculoToolStringMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoVeiculo tpvic = new FrmTipoVeiculo();
            tpvic.ShowDialog();
        }
    }
}

