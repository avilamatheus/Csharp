using System;
using System.Globalization;
using System.Collections.Generic;
using ExFix_Abst.Entities;

namespace ExFix_Abst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualincome, health));
                }
                else if(op == 'c')
                {
                    Console.Write("Number of employees: ");
                    int num = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualincome, num));
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;
            foreach(TaxPayer taxpayer in list)
            {
                Console.WriteLine(taxpayer.Name + ": $" + taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxpayer.Tax();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
