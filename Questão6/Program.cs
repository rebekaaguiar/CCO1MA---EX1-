using System;

namespace Questão6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar,cotacao,conversao;
            Console.Write("Informe o valor do dólar: US$");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor da cotação: R$");
            cotacao = double.Parse(Console.ReadLine());
            conversao = dolar * cotacao;
            Console.Write("O valor do dólar convertido em Real é: R${0} ", conversao);
        }
    }
}
