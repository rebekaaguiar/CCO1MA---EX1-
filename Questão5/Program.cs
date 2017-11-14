using System;

namespace Questão5
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Informe o grau Celsius ");
            C = double.Parse(Console.ReadLine());
            F = (9 * C + 160) / 5;
            Console.WriteLine("A conversão é {0}F.", F);
        }
    }
}
