using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Calculadora_Cientifica:Calculadora
    {
        private float raiz_quadrada;
        private float potencia;

        public float Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }

        public float Raiz_quadrada
        {
            get { return raiz_quadrada; }
            set { raiz_quadrada = value; }
        }

        public override int Soma()
        {
            return Resultado = Numero1 + Numero2;
        }
        public override int subtrair()
        {
            return Resultado = Numero1 - Numero2;
        }
        public override double multiplicar()
        {
            return Resultado = Numero1 * Numero2;
        }
        public override double dividir()
        {
            return Resultado = Numero1 / Numero2;
        }

        public double pot() 
        {
            
                Resultado = Math.Sqrt(Numero1);
        }
    }
}
