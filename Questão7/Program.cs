using System;

namespace Questão7
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposito, rendimento;
            Console.Write("Informe o valor depositado: R$");
            deposito = double.Parse(Console.ReadLine());
            rendimento = ((deposito / 100) * 0.70) + deposito;
            Console.Write("O rendimento será de: R${0} ", rendimento);

        }
    }
}
