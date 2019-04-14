using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    abstract class Calculadora
    {
        private int numero1;
        private int numero2;
        private float resultado;

        public int Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

        public int Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }
        

        public int Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        abstract public int Soma();

        abstract public int subtrair();

        abstract public double multiplicar();

        abstract public double dividir();
    }
}


        /*public int Somar()
        {
            return resultado = numero1 + numero2;
        }
        public int subtracao()
        {
            return resultado = numero1 - numero2;
        }
        public float Multiplicacao()
        {
            return resultado = numero1 * numero2;
        }
        public float dividir()
        {
            return resultado = numero1 / numero2;
        }*/