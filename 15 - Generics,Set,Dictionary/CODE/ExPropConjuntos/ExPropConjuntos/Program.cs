using System;
using System.Collections.Generic;

namespace ExPropConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ids = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            Add(ids, a);
            Console.Write("How many students for course B? ");
            a = int.Parse(Console.ReadLine());
            Add(ids, a);
            Console.Write("How many students for course C? ");
            a = int.Parse(Console.ReadLine());
            Add(ids, a);
            Console.WriteLine("Total students: " + ids.Count);
        }

        static void Add(HashSet<int> ids, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int id = int.Parse(Console.ReadLine());
                ids.Add(id);
            }
        }
    }
}
