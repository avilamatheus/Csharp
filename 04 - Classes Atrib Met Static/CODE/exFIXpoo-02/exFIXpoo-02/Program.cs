using System;
using System.Globalization;

namespace exFIXpoo_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x;
            x = new Funcionario();
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Funcionário: " + x);
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentarSalario(porc);
            Console.WriteLine("Dados atualizados: " + x);
        }
    }
}
