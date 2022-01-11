using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex_Fix_Listas
{
    class Empregado
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Empregado(int id, string name, double salary)
        {
            Id = id;
            Nome = name;
            Salario = salary;
        }

        public void AumentarSalario (double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome  
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
