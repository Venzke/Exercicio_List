using System;
using System.Globalization;

namespace Curso
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public double Salario { get; private set; }

    public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem) {

             Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
