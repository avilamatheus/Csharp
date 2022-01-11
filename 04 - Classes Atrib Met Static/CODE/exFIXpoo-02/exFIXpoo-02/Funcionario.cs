using System;
using System.Globalization;

namespace exFIXpoo_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * (1 + (porcentagem / 100));
            return SalarioBruto;
        }

        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
