using System;

namespace Questão8
{
    class Program
    {
        static void Main(string[] args)
        {
            double compra, prestacoes;
            Console.Write("Informe o valor da compra: R$");
            compra = double.Parse(Console.ReadLine());
            prestacoes = compra / 5;
            Console.Write("Serão pagas 5 prestações de R${0} ", prestacoes);
        }
    }
}
