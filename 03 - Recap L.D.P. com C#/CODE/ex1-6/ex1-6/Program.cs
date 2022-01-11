using System;
using System.Globalization;

namespace ex1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string[] vec = Console.ReadLine().Split(' ');
            a = double.Parse(vec[0], CultureInfo.InvariantCulture);
            b = double.Parse(vec[1], CultureInfo.InvariantCulture);
            c = double.Parse(vec[2], CultureInfo.InvariantCulture);
            double AreaTriangulo = (a * c) / 2.0;
            double AreaCirculo = 3.14159 * (Math.Pow(c, 2));
            double AreaTrap = ((a + b) * c) / 2.0;
            double AreaQuadrado = Math.Pow(b, 2);
            double AreaRetangulo = a * b;
            Console.WriteLine("TRIANGULO: " + AreaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + AreaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + AreaTrap.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + AreaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + AreaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
