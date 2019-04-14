using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valor_Ingresso
{
    class Ingresso
    {
        private double valor =20.00;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public virtual double ImprimirValor() 
        {
            
            return valor;
        }
        
    }
}
