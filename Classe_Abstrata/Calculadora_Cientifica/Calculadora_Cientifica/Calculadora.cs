using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Cientifica
{
    abstract class Calculadora
    {
        private double numero1;
        private double numero2;
        private double resultado;

        public double Numero1 { get => numero1; set => numero1 = value; }
        public double Numero2 { get => numero2; set => numero2 = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        abstract public double Soma();
        abstract public double Subtracao();
        abstract public double multiplicacao();
        abstract public double divisao();
    }
}
