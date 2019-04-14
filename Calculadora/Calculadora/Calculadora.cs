using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        private double n1;
        private double n2;
        private double result;

        public double N1
        {
            get { return n1; }
            set { n1 = value; }
        }

        public double N2
        {
            get { return n2; }
            set { n2 = value; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public void Somar()
        {
            this.result = n1 + n2;
        }
        public void Subtrair()
        {
            this.result = n1 - n2;
        }
        public void Multiplicar()
        {
            this.result = n1 * n2;
        }
        public void Dividir()
        {
            if (n1 > 0)
            {
                this.result = n1 / n2;
            }
        }



    }
}
