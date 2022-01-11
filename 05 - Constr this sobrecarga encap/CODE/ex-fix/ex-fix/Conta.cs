using System;
using System.Globalization;

namespace ex_fix
{
    class Conta
    {
        public string Nome { get; set; }
        public int Num { get; private set; }
        public double Cash { get; private set; }
        public Conta(string nome, int num)
        {
            Nome = nome;
            Num = num;
        }
        public Conta(string nome, int num, double cash) : this(nome, num)
        {
            Deposito(cash);
        }
        public void Deposito(double valor)
        {
            if(valor > 0)
            {
                Cash = Cash + valor;
            }
        }
        public void Saque(double valor)
        {
            double tax = 5.00;
            if (valor > 0)
            {
                Cash = Cash - valor - tax;
            }
        }
        public override string ToString()
        {
            return "Conta " + Num.ToString() + ", Titular: " + Nome + ", Saldo: $ " + Cash.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
