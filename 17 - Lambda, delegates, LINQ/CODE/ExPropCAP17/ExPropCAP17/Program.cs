using System;
using System.IO;
using System.Linq;
using System.Globalization;
using ExPropCAP17.Entities;
using System.Collections.Generic;

namespace ExPropCAP17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            try
            {
                List<Employee> list = new List<Employee>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] data = sr.ReadLine().Split(',');
                        string name = data[0];
                        string email = data[1];
                        double salary = double.Parse(data[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }
                Console.Write("Enter Salary: ");
                double salaryreference = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                var emails = list.Where(p => p.Salary > salaryreference).OrderBy(p => p.Email).Select(p => p.Email);
                Console.WriteLine("Email of people whose salary is more than " + salaryreference.ToString("F2", CultureInfo.InvariantCulture) + ":");
                foreach(string email in emails)
                {
                    Console.WriteLine(email);
                }
                var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
                Console.Write("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
