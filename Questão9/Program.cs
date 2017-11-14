using System;

namespace Questão9
{
    class Program
    {
        static void Main(string[] args)
        {
            double custo, acrescimo;
            Console.Write("Informe o valor de custo: R$");
            custo = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor do acréscimo: R$");
            acrescimo = double.Parse(Console.ReadLine());
            Console.Write("O valor de venda será de R${0} ", acrescimo+custo);

        }
    }
}
