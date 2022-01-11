using System;

namespace ex4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                int x = i;
                int y = i * i;
                int z = i * i * i;
                Console.WriteLine("{0} {1} {2}", x, y, z);
            }
        }
    }
}
