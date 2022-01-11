using System;
using System.Collections.Generic;
using System.Text;

namespace ExFix_Abst.Entities
{
    class Company : TaxPayer
    {
        public int NumEmp { get; set; }

        public Company(string name, double anualIncome, int numEmp) : base(name, anualIncome)
        {
            NumEmp = numEmp;
        }
        public override double Tax()
        {
            if(NumEmp > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

    }
}
