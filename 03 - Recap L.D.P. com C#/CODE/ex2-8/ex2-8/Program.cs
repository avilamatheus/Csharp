using System;
using System.Globalization;
namespace ex2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tax;
            if(salary <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(salary <= 3000.00)
            {
                tax = 0.08 * (salary - 2000.00);
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if(salary <= 4500.00)
            {
                tax = 0.18 * (salary - 3000) + 1000 * 0.08;
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                tax = 0.28 * (salary - 4500) + 1500 * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$ " + tax.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
