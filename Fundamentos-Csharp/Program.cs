
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

Console.WriteLine("Digite um número: ");


