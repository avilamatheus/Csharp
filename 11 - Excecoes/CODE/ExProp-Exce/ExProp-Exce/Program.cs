using System;
using System.Globalization;
using ExProp_Exce.Entities;
using ExProp_Exce.Entities.Exceptions;

namespace ExProp_Exce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            bool validnumber = false;
            int number = 0;
            while (!validnumber)
            {
                try
                {
                    Console.Write("Number: ");
                    number = int.Parse(Console.ReadLine());
                    validnumber = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, must be an number");
                }
            }
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account acc = new Account(number, holder, balance, limit);
            Console.WriteLine();
            bool validwithdraw = false;
            while (!validwithdraw)
            {
                try
                {
                    Console.Write("Enter amount for withdraw: ");
                    double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    acc.Withdraw(withdraw);
                    Console.WriteLine("New balance: " + acc.Balance);
                    validwithdraw = true;
                }
                catch (DomainException error)
                {
                    Console.WriteLine("Withdraw error: " + error.Message);
                }
            }

        }
    }
}
