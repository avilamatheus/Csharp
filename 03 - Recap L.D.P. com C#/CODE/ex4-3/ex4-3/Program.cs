using System;
using System.Globalization;

namespace ex4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] vec = Console.ReadLine().Split(' ');
                double a = double.Parse(vec[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vec[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vec[2], CultureInfo.InvariantCulture);
                double media = ((a * 2.0) + (b * 3.0) + (c * 5.0)) / (10.0);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
