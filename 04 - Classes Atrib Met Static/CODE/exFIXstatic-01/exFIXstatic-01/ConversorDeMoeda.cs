using System;
using System.Globalization;

namespace exFIXstatic_01
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.0;
        public static double Calc(double qtd, double cot)
        {
            double total = (cot * qtd) * (1 + (IOF/100));
            return total;
        }
    }
}
