# 001.001. Pessoa
Crie uma classe chamada "Pessoa" com as propriedades "Nome" e "Idade". Implemente também um método chamado "Apresentar" que exibe uma mensagem com o nome e a idade da pessoa.
# 001.002. Retangulo
Crie uma classe chamada "Retangulo" com as propriedades "Largura" e "Altura". Implemente uma propriedade chamada "Area" que calcula e retorna a área do retângulo (Largura * Altura).
# 001.003. ContaBancaria
Escreva uma classe chamada "ContaBancaria" com as propriedades "Saldo" e "Limite". Implemente métodos para depositar e sacar dinheiro da conta. Certifique-se de que o saldo não ultrapasse o limite estabelecido.
# 001.004. Livro
Crie uma classe chamada "Livro" com as propriedades "Titulo", "Autor" e "AnoPublicacao". Implemente uma propriedade chamada "Edicao" que permite ler e redefinir o número da edição do livro.
# 001.005. Circulo
Crie uma classe chamada "Circulo" com a propriedade "Raio". Implemente uma propriedade chamada "Diametro" que calcula e retorna o diâmetro do círculo (2 * Raio).
# 001.006. Aluno
Escreva uma classe chamada "Aluno" com as propriedades "Nome" e "Notas" (um array de double). Implemente uma propriedade chamada "Media" que calcula a média das notas do aluno.
# 001.007. Carro
Crie uma classe chamada "Carro" com as propriedades "Marca" e "Modelo". Implemente uma propriedade chamada "Descricao" que concatene a marca e o modelo em uma única string.
# 001.008.
Escreva uma classe chamada "Triangulo" com as propriedades "LadoA", "LadoB" e "LadoC". Implemente uma propriedade chamada "Perimetro" que calcula e retorna o perímetro do triângulo (LadoA + LadoB + LadoC).
# 001.009.
Crie uma classe chamada "Produto" com as propriedades "Nome", "Preco" e "Desconto". Implemente uma propriedade chamada "PrecoComDesconto" que calcula e retorna o preço do produto com desconto aplicado.
# 001.010.
Escreva uma classe chamada "Funcionario" com as propriedades "Nome" e "Salario". Implemente uma propriedade chamada "SalarioAnual" que calcula e retorna o salário anual do funcionário (Salario * 12). Sobrecarga de Métodos:
## 002.001.
Crie uma classe chamada "Calculadora" com um método chamado "Somar" que recebe dois inteiros como parâmetros e retorna a soma desses números. Sobrecarregue o método "Somar" para que também seja possível somar dois números decimais.
## 002.002.
Escreva uma classe chamada "Conversor" com um método chamado "Converter" que recebe um valor em dólares e retorna o equivalente em reais. Sobrecarregue o método "Converter" para que também seja possível converter de reais para dólares.
## 002.003.
Crie uma classe chamada "Matematica" com um método chamado "Calcular" que recebe um array de inteiros e retorna a soma de todos os elementos do array. Sobrecarregue o método "Calcular" para que também seja possível calcular a média dos valores presentes no array.
## 002.004.
Escreva uma classe chamada "ManipuladorTexto" com um método chamado "Inverter" que recebe uma string e retorna a mesma string invertida. Sobrecarregue o método "Inverter" para que também seja possível inverter um array de caracteres.
## 002.005.
Crie uma classe chamada "CalculadoraGeometrica" com um método chamado "CalcularArea" que recebe as medidas de um retângulo (largura e altura) e retorna a área do retângulo. Sobrecarregue o método "CalcularArea" para que também seja possível calcular a área de um círculo (raio) e de um triângulo (base e altura).
## 002.006.
Escreva uma classe chamada "Comparador" com um método chamado "Maior" que recebe dois inteiros como parâmetros e retorna o maior deles. Sobrecarregue o método "Maior" para que também seja possível comparar dois números decimais e retornar o maior deles.
## 002.007.
Crie uma classe chamada "ManipuladorArquivo" com um método chamado "LerArquivo" que recebe o nome de um arquivo como parâmetro e retorna o conteúdo desse arquivo como uma string. Sobrecarregue o método "LerArquivo" para que também seja possível ler um arquivo fornecendo o caminho completo.
## 002.008.
Escreva uma classe chamada "ConversorUnidades" com um método chamado "ConverterMetroParaCentimetro" que recebe um valor em metro e retorna o equivalente em centímetros. Sobrecarregue o método "ConverterMetroParaCentimetro" para que também seja possível converter de centímetros para metros.
## 002.009.
Crie uma classe chamada "ManipuladorLista" com um método chamado "RemoverElemento" que recebe uma lista de inteiros e um número como parâmetros, e remove todas as ocorrências desse número da lista. Sobrecarregue o método "RemoverElemento" para que também seja possível remover um elemento pelo índice.
## 002.010.
Escreva uma classe chamada "OperacoesMatematicas" com um método chamado "Calcular" que recebe uma expressão matemática como parâmetro (por exemplo, "2+3*4") e retorna o resultado dessa expressão. Sobrecarregue o método "Calcular" para que também seja possível receber os valores separadamente (por exemplo, Calcular(2, "+", 3, "*", 4)). Enumerações:
### 003.001.
Crie uma enumeração chamada "DiasDaSemana" que representa os dias da semana (segunda a domingo). Em seguida, exiba todos os valores da enumeração.
### 003.002.
Escreva um programa que solicite ao usuário que digite um número de 1 a 7 e, em seguida, exiba o dia da semana correspondente com base no número fornecido. Utilize a enumeração "DiasDaSemana" para realizar essa correspondência.
### 003.003.
Crie uma enumeração chamada "MesesDoAno" que representa os meses do ano (janeiro a dezembro). Implemente um método que receba um valor numérico inteiro correspondente a um mês e retorne o nome do mês correspondente utilizando a enumeração.
### 003.004.
Escreva um programa que leia o nome de um mês do usuário e verifique se o mês fornecido é um mês de verão (dezembro, janeiro ou fevereiro). Utilize a enumeração "MesesDoAno" para realizar essa verificação.
### 003.005.
Crie uma enumeração chamada "TamanhoCamiseta" com os valores "Pequeno", "Médio" e "Grande". Implemente um método que receba um valor do tipo "TamanhoCamiseta" e exiba uma mensagem correspondente informando o tamanho da camiseta.
### 003.006.
Escreva uma classe chamada "Pedido" com uma propriedade chamada "Status" do tipo enumeração "StatusPedido" com os valores "Novo", "Processando", "Enviado" e "Entregue". Implemente métodos que permitam atualizar o status do pedido e exibir o status atual.
### 003.007.
Crie uma enumeração chamada "EstacoesAno" com os valores "Primavera", "Verão", "Outono" e "Inverno". Implemente um programa que solicite ao usuário que digite uma estação do ano e exiba uma mensagem correspondente com base na enumeração.
### 003.008.
Escreva um programa que leia um valor numérico de 1 a 12 que represente um mês do ano. Em seguida, verifique se o mês fornecido é considerado um mês de alta temporada de viagens (julho a fevereiro). Utilize a enumeração "MesesDoAno" para realizar essa verificação.
### 003.009.
Crie uma enumeração chamada "TipoVeiculo" com os valores "Carro", "Moto" e "Caminhao". Implemente um método que receba um valor do tipo "TipoVeiculo" e exiba uma mensagem correspondente informando o tipo de veículo.
### 003.010.
Escreva um programa que exiba todos os valores da enumeração "DayOfWeek" do namespace System. Utilize um loop para percorrer os valores e exibi-los.
