using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex_Fix_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            List<Empregado> list = new List<Empregado>();
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine("Employee #" + (i+1) + ":");
                Console.Write("ID: ");
                int idadd = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(idadd, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase : ");
            int id = int.Parse(Console.ReadLine());
            int index = list.FindIndex(x => x.Id == id);
            if(index == -1)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list[index].AumentarSalario(porcentagem);
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");
            foreach(Empregado obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
