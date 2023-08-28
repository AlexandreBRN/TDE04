using System;

// namespace ExemploVariaveis
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string nome = "Paulo";
//             int idade = 17;
//             double nota = 7.5;

            
//             string saidaConcatenacao = "Aluno " + nome + " tem " + idade + " anos e nota " + nota + ".";

            
//             string saidaInterpolacao = $"Aluno {nome} tem {idade} anos e nota {nota}.";

            
//             Console.WriteLine(saidaConcatenacao);
//             Console.WriteLine(saidaInterpolacao);
//         }
//     }
// }



// namespace ExemploVariaveis
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string nome = "Paulo";
//             int idade = 17;
//             double nota = 7.5;

//             // Exibindo em linhas separadas usando sequências de escape
//             Console.WriteLine("Nome: " + nome);
//             Console.WriteLine("Idade: " + idade);
//             Console.WriteLine("Nota: " + nota);
//         }
//     }
// }



// namespace ExemploReversaoString
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite três letras:");
//             string input = Console.ReadLine();

//             if (input.Length != 3)
//             {
//                 Console.WriteLine("Você deve digitar exatamente três letras.");
//                 return;
//             }

//             string reversedConcatenation = input[2].ToString() + input[1].ToString() + input[0].ToString();
         
//             string reversedInterpolation = $"{input[2]}{input[1]}{input[0]}";

//             Console.WriteLine("Reversão usando concatenação: " + reversedConcatenation);
//             Console.WriteLine("Reversão usando interpolação: " + reversedInterpolation);
//         }
//     }
// }



// namespace ExemploOperacoesMatematicas
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite o primeiro valor:");
//             double valor1 = Convert.ToDouble(Console.ReadLine());

//             Console.WriteLine("Digite o segundo valor:");
//             double valor2 = Convert.ToDouble(Console.ReadLine());

//             double soma = valor1 + valor2;
//             double subtracao = valor1 - valor2;
//             double multiplicacao = valor1 * valor2;
//             double exponenciacao = Math.Pow(valor1, valor2);
//             double divisao = valor1 / valor2;
//             double modulo = valor1 % valor2;

//             Console.WriteLine($"Soma: {soma}");
//             Console.WriteLine($"Subtração: {subtracao}");
//             Console.WriteLine($"Multiplicação: {multiplicacao}");
//             Console.WriteLine($"Exponenciação: {exponenciacao}");
//             Console.WriteLine($"Divisão: {divisao}");
//             Console.WriteLine($"Módulo: {modulo}");
//         }
//     }
// }



// namespace ExemploBhaskara
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             double a = 1;
//             double b = 12;
//             double c = -13;

//             double delta = Math.Pow(b, 2) - 4 * a * c;

//             if (delta < 0)
//             {
//                 Console.WriteLine("A equação não possui raízes reais.");
//             }
//             else
//             {
//                 double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
//                 double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

//                 Console.WriteLine($"Raiz 1: {raiz1}");
//                 Console.WriteLine($"Raiz 2: {raiz2}");
//             }
//         }
//     }
// }



// namespace ExemploVerificacaoLogin
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite o nome:");
//             string nome = Console.ReadLine();

//             Console.WriteLine("Digite a senha:");
//             int senha = Convert.ToInt32(Console.ReadLine());

//             string mensagem = (nome == "admin" || nome == "maria") && senha == 123
//                 ? "Login feito com sucesso"
//                 : "Login inválido";

//             Console.WriteLine(mensagem);
//         }
//     }
// }



// namespace ExemploVerificacaoPar
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite o valor de x:");
//             int x = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Digite o valor de y:");
//             int y = Convert.ToInt32(Console.ReadLine());

//             string xPar = x % 2 == 0 ? "par" : "ímpar";
//             string yPar = y % 2 == 0 ? "par" : "ímpar";

//             Console.WriteLine($"x é {xPar}");
//             Console.WriteLine($"y é {yPar}");
//         }
//     }
// }
