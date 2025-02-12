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
            Console.WriteLine("###### Atividade 1 ######");
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

        }
    }
}
