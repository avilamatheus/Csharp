using System;

namespace ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int password = int.Parse(Console.ReadLine());
            while (password != 2002)
            {
                Console.WriteLine("Senha Invalida");
                password = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}
