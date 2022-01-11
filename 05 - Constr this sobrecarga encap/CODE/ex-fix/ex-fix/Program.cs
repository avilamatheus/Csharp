using System;
using System.Globalization;

namespace ex_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            int num;
            string titular;
            double cash;
            Console.Write("Insira o número da conta: ");
            num = int.Parse(Console.ReadLine());
            Console.Write("Insira o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial (s/n)? ");
            string op = Console.ReadLine();
            if (op == "s")
            {
                Console.Write("Insira o valor do deposito inicial: ");
                cash = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(titular, num, cash);
            }
            else
            {
                conta = new Conta(titular, num);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
            Console.WriteLine();
        }
    }
}
