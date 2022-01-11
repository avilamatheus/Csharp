using System;
using System.Globalization;

namespace ex1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, num1, num2;
            double price1, price2, total;
            string[] vec1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vec1[0]);
            num1 = int.Parse(vec1[1]);
            price1 = double.Parse(vec1[2], CultureInfo.InvariantCulture);
            vec1 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vec1[0]);
            num2 = int.Parse(vec1[1]);
            price2 = double.Parse(vec1[2], CultureInfo.InvariantCulture);
            total = (price1 * num1) + (price2 * num2);
            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
