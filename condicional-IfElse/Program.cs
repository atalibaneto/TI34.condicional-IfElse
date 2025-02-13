using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace condicional_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Para tirar CNH precisa ter mais de 18 anos. Vamos verificar sua idade");
            //Console.WriteLine("Digite sua idade: ");
            //int idade = Convert.ToInt32(Console.ReadLine());
            //if (idade >= 18)
            //{
            //    Console.WriteLine("Parabéns, você já pode tirar sua CNH");
            //}
            //else
            //{
            //    Console.WriteLine("Espere fazer 18 anos para tirar a CNH");
            //}
            //Console.WriteLine("\n###### Atividade 1 ######");
            //Console.WriteLine("Digite sua idade para verificar a maioridade");
            //int maioridade = Convert.ToInt32(Console.ReadLine());
            //if (maioridade >= 18)
            //{
            //    Console.WriteLine("Você é maior de idade");
            //}
            //else
            //{
            //    Console.WriteLine("Você é menor de idade");
            //}
            //Console.WriteLine("\n###### Atividade 2 ######");
            //Console.WriteLine("Verificar se o número é positivo, negativo ou zero");
            //int numero = Convert.ToInt32(Console.ReadLine());
            //if (numero > 0)
            //{
            //    Console.WriteLine("Número positivo");
            //}
            //else if (numero < 0)
            //{
            //    Console.WriteLine("Número negativo");
            //}
            //else
            //{
            //    Console.WriteLine("O número é igual a zero");
            //}
            //Console.WriteLine("\n###### Atividade 3 ######");
            //Console.WriteLine("Verificar qual o número é maior ou se são iguais");
            //Console.WriteLine("Digite o primeiro número");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //if (numero1 > numero2)
            //{
            //    Console.WriteLine("O primeiro número é maior que o segundo");
            //    Console.WriteLine($"{numero1} > {numero2}");
            //}
            //else if (numero2 > numero1)
            //{
            //    Console.WriteLine("O segundo número é maior que o primeiro");
            //    Console.WriteLine($"{numero2} > {numero1}");
            //}
            //else
            //{
            //    Console.WriteLine("Os números são iguais");
            //    Console.WriteLine($"{numero1} = {numero2}");
            //}
            //Console.WriteLine("\n###### Atividade 4 ######");
            //Console.WriteLine("O usuário digita a nota de um aluno e o programa informa se ele foi aprovado (nota maior ou igual a 6) ou reprovado");
            //Console.Write("Digite a uma nota: ");
            //int nota1 = Convert.ToInt32(Console.ReadLine());
            //if (nota1 >= 6)
            //{
            //    Console.WriteLine("Aluno aprovado");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno reprovado");
            //}
            //Console.WriteLine("\n###### Atividade 5 ######");
            //Console.WriteLine("O usuário digita uma senha e o programa verifica se ela está correta (senha correta 1234)");
            //Console.WriteLine("Digite a senha");
            //int senha = Convert.ToInt32(Console.ReadLine());
            //if (senha == 1234)
            //{
            //    Console.WriteLine("Senha Correta!");
            //}
            //else
            //{
            //    Console.WriteLine("Senha Incorreta!");
            //}
            //Console.WriteLine("\n###### Exemplo Ternário ######");
            //int hora = 20;
            //string resultado = (hora < 18) ? "Bom dia" : "Boa noite";
            //Console.WriteLine(resultado);
            //Console.WriteLine("\n###### Exemplo Switch  1 ######");
            //int combo = 1;
            //switch (combo)
            //{
            //    case 1:
            //        Console.WriteLine("Combo 1 - Hamburguer, fritas e refri");
            //        break;
            //    case 2:
            //        Console.WriteLine("Combo 2 - Fritas e refri");
            //        break;
            //    case 3:
            //        Console.WriteLine("Combo 3 - Fritas e Milkshake");
            //        break;
            //}
            //Console.WriteLine("\n###### Exemplo Switch  2 ######");
            //int sw2 = 2;
            //switch (sw2)
            //{
            //    case 1:
            //        Console.WriteLine("O número é 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("O número é 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("O número é 3");
            //        break;
            //    default:
            //        Console.WriteLine("Número desconhecido");
            //        break;
            //}
            //Console.WriteLine("\n###### Exemplo Switch  3 ######");
            //string cor = "vermelho";
            //switch (cor)
            //{
            //    case "azul":
            //        Console.WriteLine("A cor é azul");
            //        break;
            //    case "vermelho":
            //        Console.WriteLine("A cor é vermelho");
            //        break;
            //    default:
            //        Console.WriteLine("Cor desconhecida");
            //        break;
            //}
            //Console.WriteLine("\n###### Exemplo Switch  4 ######");
            //char letra = 'A';
            //switch (letra)
            //{
            //    case 'A':
            //    case 'E':
            //    case 'I':
            //    case 'O':
            //    case 'U':

            //        Console.WriteLine("É uma vogal");
            //        break;
            //    default:
            //        Console.WriteLine("Não é uma vogal");
            //        break;
            //}
            //Console.WriteLine("\n###### Atividade Switch  1 ######");
            //Console.WriteLine("Digite um número de 1 a 7 para descobrir o dia da semana correspondente");
            //int numeroDiaSemana = Convert.ToInt32(Console.ReadLine());
            //switch (numeroDiaSemana)
            //{
            //    case 1:
            //        Console.WriteLine("Domingo");
            //        break;
            //    case 2:
            //        Console.WriteLine("Segunda-feira");
            //        break;
            //    case 3:
            //        Console.WriteLine("Terça-feira");
            //        break;
            //    case 4:
            //        Console.WriteLine("Quarta-feira");
            //        break;
            //    case 5:
            //        Console.WriteLine("Quinta-feira");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sexta-feira");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sábado");
            //        break;
            //}
            Console.WriteLine("\n###### Atividade Switch  2 ######");
            Console.WriteLine("Digite dois números e após isso, digite a operação (+, -, *, /)");
            Console.WriteLine("Digite o primeiro número");
            double numeroCalculadora1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double numeroCalculadora2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a operação desejada (+, -, *, /)");
            char operacao = Console.ReadKey().KeyChar;
            switch (operacao)
            {
                case '+':
                    double soma = numeroCalculadora1 + numeroCalculadora2;
                    Console.WriteLine($"\nA soma entre os números {numeroCalculadora1} e {numeroCalculadora2} é {soma}");
                    break;
                case '-':
                    double subtracao = numeroCalculadora1 + numeroCalculadora2;
                    Console.WriteLine($"\nA subtracao entre os números {numeroCalculadora1} e {numeroCalculadora2} é {subtracao}");
                    break;
                case '*':
                    double multiplicacao = numeroCalculadora1 + numeroCalculadora2;
                    Console.WriteLine($"\nA soma entre os números {numeroCalculadora1} e {numeroCalculadora2} é {multiplicacao}");
                    break;
                case '/':
                    double divisao = numeroCalculadora1 + numeroCalculadora2;
                    Console.WriteLine($"\nA soma entre os números {numeroCalculadora1} e {numeroCalculadora2} é {divisao}");
                    break;
            }
        }
    }
}