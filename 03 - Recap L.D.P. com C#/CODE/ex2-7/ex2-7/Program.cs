using System;
using System.Globalization;

namespace ex2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);
            //q1 = x+ y+
            //q2 = x- y+
            //q3 = x- y-
            //q4 = x+ y-
            //eixo x => y = 0
            //eixo y => x = 0
            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if(x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
