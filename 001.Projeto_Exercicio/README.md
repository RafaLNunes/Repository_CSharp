# Exercicio pedido pelo professor

## Parte 1)
Criar um programa que leia: O nome de um aluno, suas quatro notas bimestrais, a média para aprovação, a média ́para recuperação e a quantidade de aulas dadas. O programa deverá mostrar o nome do aluno, sua situação geral, ("Aprovado", "Recuperação", reprovado por Faltas" ou "Reprovado por média"). Sabe-se que o percentual mínimo de frequência é de 75%. 

## Parte 2)
Elabore um programa que calcule as raízes de uma equação do segundo grau (Bhaskara) ax2+bx-c=0, sabe-se que a fórmula é: $$\frac{-b\pm\sqrt{b^{2}-4ac}}{2a}$$ O programa deverá verificar se o delta(Δ) é maior, menor ou igual a 0. sendo o Delta > 0 haverá duas raízes iguais e distintas, o Delta < 0 não haverá raízes reais e o Delta = 0 existem duas raízes iguais e distintas. 

## Parte 3)
Criar um aplicativo para efetuar o cálculo do valor de uma prestação em atraso, utilizando a fórmula: PRESTAÇÃO:=VALOR+(VALOR*(TAXA/100) *TEMPO).

# Como Foi Resolvido
**oque foi feito no C#**

## Parte 1)
Foi criado uma aba chamada Aluno e dentro dela uma chamda média onde o usuário deve Informar:

* Nome
* Unidade escolar
* 1° Nota bimestral
* 2° Nota bimestral
* 3° Nota bimestral
* 4° Nota bimestral
* E Clicar em Enter
* Então etão saberá sua média e se passou de ano ou não

## Parte 2)

Foi criado uma aba chamada Calculo e dentro dela uma chamada Bhaskara onde o Usuário informará:

* Substituto da variavel a
* Substituto da variavel b
* Substituto da variavel c
* Ao Clicar no botão aparecerá as duas opções de x & a equação $a \cdot x2+b \cdot x-c=0$ será completada com os respectivos números

## Parte 3)

Foi Criado uma aba chamada prestação de serviço e dentro uma chamada com juros onde o Usuário entrará com:

* O valor utilizado na prestação
* O tempo que durou a prestação
* A Taxa da prestação
* Ao clicar no botão Enter aparecerá o resultado de sua prestação


# Funcionamento


| Home | Aluno | Calculo | Prestação de Serviço |
| -------------------- | -------------------- | -------------------- | -------------------- |
| Pagina Principal | Média | Bhaskara | Com Juros |
| Escolhas as Abas | Ijetar iformações | Ijetar iformações | Ijetar iformações | 

# Partes Interessantes do Código

**O Bloco de codigo A baixo foi utilizado para fazer uma função de placeholder chamada marck:**
```C#
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
```
**Nesse Bloco de codigo a seguir foi usado para completar a equação do bhaskara:**
```C#
            label2.Text = $"{textBox1.Text}x2+";

            label2.Text += $"{textBox2.Text}x-";

            label2.Text += $"{textBox3.Text}=0";


            A = Double.Parse(textBox1.Text);
            B = Double.Parse(textBox2.Text);
            C = Double.Parse(textBox3.Text);
            delta = Math.Pow(B, 2) - 4 * A * C;
            bhkn = (-B - Math.Sqrt(delta)) / 2 * A;
            bhkp = (-B + Math.Sqrt(delta)) / 2 * A;

            label1.Text = $"X1 = {bhkn}";
            label3.Text = $"X2 = {bhkp}";
```
