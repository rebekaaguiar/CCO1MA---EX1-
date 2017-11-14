using System;

namespace Questão1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Informe o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos dois valores é: {0}", num1 + num2);
        }
    }
}
