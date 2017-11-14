using System;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Informe o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("A soma é {0}.", n1 + n2);
            Console.WriteLine("A subtração é {0}.", n1 - n2);
            Console.WriteLine("A divisão é {0}.", n1 / n2);
            Console.WriteLine("A multiplicação é {0}.", n1 * n2);

        }
    }
}
