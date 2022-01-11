using System;
using System.Globalization;

namespace exFIXstatic_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar: ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valro a ser pago em reais = " + ConversorDeMoeda.Calc(qtd, cot).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
