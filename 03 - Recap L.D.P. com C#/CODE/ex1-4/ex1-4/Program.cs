using System;
using System.Globalization;
namespace ex1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double hour, wage, total;
            number = int.Parse(Console.ReadLine());
            hour = double.Parse(Console.ReadLine());
            wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            total = wage * hour;
            Console.WriteLine("NUMBER = {0}", number);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
