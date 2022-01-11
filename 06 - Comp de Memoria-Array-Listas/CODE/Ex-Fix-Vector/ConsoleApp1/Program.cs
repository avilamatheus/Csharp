using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Person[] rooms = new Person[10];
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Rent #" + (i) + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numRoom = int.Parse(Console.ReadLine());
                rooms[numRoom] = new Person(name, email);
                Console.WriteLine();
            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine(i+": " + rooms[i].ToString());
                }
            }
        }
    }
}
