using System;
using System.Collections.Generic;
using System.Text;

namespace ExFix_Abst.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExp { get; set; }

        public Individual(string name, double anualIncome, double healthExp) : base(name, anualIncome)
        {
            HealthExp = healthExp;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExp * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExp * 0.5;
            }
        }
    }
}
