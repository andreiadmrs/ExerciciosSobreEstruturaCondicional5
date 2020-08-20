using System;
using System.Globalization;

namespace ExerciciosSobreEstruturaCondicional5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
            seguir, calcule e mostre o valor da conta a pagar.*/

            Console.WriteLine("Codigo do item:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade do item:");
            int quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1)
            {
                double valor = 4.00 * quantidade;
                Console.WriteLine("O valor total dos hotdogs é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 2)
            {
                double valor = 4.50 * quantidade;
                Console.WriteLine("O valor total dos x-saladas é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            } else if (codigo == 3)
            {
                double valor = 5.00 * quantidade;
                Console.WriteLine("O valor total dos x-bacons é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 4)
            {
                double valor = 2.00 * quantidade;
                Console.WriteLine("O valor total das torradas simples é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (codigo == 5)
            {
                double valor = 1.50 * quantidade;
                Console.WriteLine("O valor total dos refrigerantes é de R$" + valor.ToString("F2", CultureInfo.InvariantCulture));
            } if 
            
        }
    }
}
