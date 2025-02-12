using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional_IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para tirar CNH precisa ter mais de 18 anos. Vamos verificar sua idade");
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Parabéns, você já pode tirar sua CNH");
            }
            else
            {
                Console.WriteLine("Espere fazer 18 anos para tirar a CNH");
            }
            Console.WriteLine("\n###### Atividade 1 ######");
            Console.WriteLine("Digite sua idade para verificar a maioridade");
            int maioridade = Convert.ToInt32(Console.ReadLine());
            if (maioridade >= 18)
            {
                Console.WriteLine("Você é maior de idade");
            }
            else
            {
                Console.WriteLine("Você é menor de idade");
            }
            Console.WriteLine("\n###### Atividade 2 ######");
            Console.WriteLine("Verificar se o número é positivo, negativo ou zero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("Número positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Número negativo");
            }
            else
            {
                Console.WriteLine("O número é igual a zero");
            }
            Console.WriteLine("\n###### Atividade 3 ######");
            Console.WriteLine("Verificar qual o número é maior ou se são iguais");
            Console.WriteLine("Digite o primeiro número");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int numero2= Convert.ToInt32(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é maior que o segundo");
                Console.WriteLine($"{numero1} > {numero2}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("O segundo número é maior que o primeiro");
                Console.WriteLine($"{numero2} > {numero1}");
            }
            else 
            {
                Console.WriteLine("Os números são iguais");
                Console.WriteLine($"{numero1} = {numero2}");
            }


        }
    }
}
