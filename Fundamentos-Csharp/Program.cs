
// using System;
// class Program
// {
// static void Main(string[] args)
// {


// Console.WriteLine("Digite o nome do produto: ");
// string? nome = Console.ReadLine();


// string produto = "Notebook";
// decimal preco = 2599.90m;
// int quantidade = 2;
// Console.WriteLine($"Produto: {produto}");
// Console.WriteLine($"Preço: {preco:F2}");
// Console.WriteLine($"Total: {preco * quantidade:C}");
// }
// }



// Exercicio 2

// Console.WriteLine("Nome do aluno:");
// string? nome = Console.ReadLine();

// Console.WriteLine("Digite a nota:");
// decimal nota = decimal.Parse(Console.ReadLine());

// if( nota >= 7 && nota <= 10)
// {
//     Console.WriteLine("Aprovado");
// }
// else if( nota >= 5 && nota < 7)
// {
//     Console.WriteLine("Recuperação");
// }
// else if( nota < 5 && nota >= 0)
// {
//     Console.WriteLine("Reprovado");
// }
// else
// {
//     Console.WriteLine("Nota inválida");
// }



// Exercicio 3

// int numeroSecreto = 6767;
// int tentativas = 3;

// Console.WriteLine("Digite um número: ");
// int numero = int.Parse(Console.ReadLine());

// while (tentativas <= 3)
// {
//     if (numero == numeroSecreto)
//     {
//         Console.WriteLine("Parabéns! Você acertou o número secreto!");
//         break;
//     }
//     else
//     {
//         tentativas--;
//         Console.WriteLine($"Número incorreto. Você tem {tentativas} tentativas restantes.");
//         if (tentativas == 0)
//         {
//             Console.WriteLine("Suas tentativas acabaram. O número secreto era: " + numeroSecreto);
//             break;
//         }
//         Console.WriteLine("Digite outro número: ");
//         numero = int.Parse(Console.ReadLine());
//     }
// }

// Exercicio 4 

// SOMA
// Console.WriteLine("Digite o primeiro número: ");
// int numero1 = int.Parse(Console.ReadLine());

// void CalcularSoma(int num1, int num2)
// {
//     int soma = num1 + num2;
//     Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
// }

// Console.WriteLine("Digite o segundo número: ");
// int numero2 = int.Parse(Console.ReadLine());

// CalcularSoma(numero1, numero2);

// Console.WriteLine("Digite o primeiro número: ");
// int numero1 = int.Parse(Console.ReadLine());

// void Multiplicacao(int num1, int num2)
// {
//     int Multiplicacao = num1 * num2;
//     Console.WriteLine($"A multiplicação de {num1} e {num2} é: {Multiplicacao}");
// }

// Console.WriteLine("Digite o segundo número: ");
// int numero2 = int.Parse(Console.ReadLine());

// Multiplicacao(numero1, numero2);



// EXERCICIO 5

// int[] numeros = {8, 9, 10}; 

// double[] notas = new double[3];

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine($"Digite a nota do aluno {i + 1}:");
//     notas[i] = double.Parse(Console.ReadLine());
// }

// foreach (double nota in notas)
// {
//     Console.WriteLine($"Nota: {nota}");
// }

// var media = notas.Average();
// Console.WriteLine($"Média das notas: {media}");




//EXERCICIO 6

  List<string> produtos = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite o nome do produto {i}: ");
    string nome = Console.ReadLine();
    produtos.Add(nome);
 }

    Console.WriteLine("\nProdutos cadastrados:");
foreach (string produto in produtos)
    {
     Console.WriteLine($"- {produto}");
  }

    Console.Write("\nDigite o nome de um produto para buscar: ");
    string busca = Console.ReadLine();

    if (produtos.Contains(busca))
        Console.WriteLine($"O produto \"{busca}\" está na lista.");
    else
        Console.WriteLine($"O produto \"{busca}\" não está na lista.");

    Console.Write("\nDigite o nome de um produto para remover: ");
    string remover = Console.ReadLine();

    if (produtos.Remove(remover))
        Console.WriteLine($"Produto \"{remover}\" removido com sucesso.");
    else
        Console.WriteLine($"Produto \"{remover}\" não encontrado.");

        Console.WriteLine("\nLista atualizada:");
    foreach (string produto in produtos)
    {
        Console.WriteLine($"- {produto}");
    }