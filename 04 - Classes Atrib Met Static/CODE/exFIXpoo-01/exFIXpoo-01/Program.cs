﻿using System;
using System.Globalization;

namespace exFIXpoo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x;
            x = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo:");
            x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("AREA = " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
