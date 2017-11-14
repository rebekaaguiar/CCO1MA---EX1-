using System;

namespace Questão4
{
    class Program
    {
        static void Main(string[] args)
        {
            string funcionario;
            double vendasefetuadas, salario;
            Console.WriteLine("Informe o nome do funcionário: ");
            funcionario = Console.ReadLine();
            Console.Write("Informe o salário do funcionário: R$");
            salario = double.Parse(Console.ReadLine());
            Console.Write("Informe as vendas efetuadas do funcionário: R$");
            vendasefetuadas = double.Parse(Console.ReadLine());
            Console.WriteLine("O salário do funcionário no final do mês foi R${0}.", salario + (salario + vendasefetuadas * 15 / 100));
        }
    }
}
