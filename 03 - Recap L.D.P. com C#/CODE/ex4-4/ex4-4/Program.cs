using System;
using System.Globalization;

namespace ex4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] vec = Console.ReadLine().Split(' ');
                double a = double.Parse(vec[0]);
                double b = double.Parse(vec[1]);
                double div;
                if(b == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else
                {
                    div = a / b;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
