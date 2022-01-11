using System;
using System.Globalization;

namespace exFIXpoo_03
{
    class Aluno
    {
        public string Nome;
        public double P1, P2, P3;
        public double NF;
        public bool ap = false;
        public double CalcNF()
        {
            NF = P1 + P2 + P3;
            if (NF >= 60.00)
            {
                ap = true;
            }
            else
            {
                ap = false;
            }
            return NF;
        }
        public void Resultado()
        {
            if(ap)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60.00-NF).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
        
    }
}
