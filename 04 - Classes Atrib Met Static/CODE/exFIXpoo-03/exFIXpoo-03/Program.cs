using System;
using System.Globalization;
namespace exFIXpoo_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1;
            a1 = new Aluno();
            Console.Write("Nome do Aluno: ");
            a1.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a1.P1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.P2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.P3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("NOTA FINAL: " + a1.CalcNF().ToString("F2", CultureInfo.InvariantCulture));
            a1.Resultado();
        }
    }
}
