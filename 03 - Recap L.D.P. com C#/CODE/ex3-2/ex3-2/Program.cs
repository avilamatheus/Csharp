using System;

namespace ex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vec = Console.ReadLine().Split(' ');
            int x = int.Parse(vec[0]);
            int y = int.Parse(vec[1]);
            while (x != 0 && y != 0)
            {
                if(x>0 && y>0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if(x<0 && y>0)
                {
                    Console.WriteLine("Segundo");
                }
                else if(x<0 && y<0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                vec = Console.ReadLine().Split(' ');
                x = int.Parse(vec[0]);
                y = int.Parse(vec[1]);
            }


        }
    }
}
