using System;

namespace ex2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int inicial = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);
            int total;
            if (inicial<final)
            {
                total = final - inicial;
            }
            else
            {
                total = 24 - inicial + final;
            }
            Console.WriteLine("O JOGO DUROU {0} HORA(S)", total);
        }
    }
}
