using System;

namespace ex4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numin = 0, numout = 0;
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(x>=10 && x<=20)
                {
                    numin = numin + 1;
                }
                else
                {
                    numout = numout + 1;
                }
            }
            Console.WriteLine("{0} in", numin);
            Console.WriteLine("{0} out", numout);
        }
    }
}
