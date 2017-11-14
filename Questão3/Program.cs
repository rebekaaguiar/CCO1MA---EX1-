using System;

namespace Questão3
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia, combustivel;
            Console.WriteLine("Forneça a distância total percorrida: ");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o total de combustível gasto: ");
            combustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("O consumo médio do automóvel foi {0}Km/L.", distancia / combustivel);
        }
    }
}
