using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valor_Ingresso
{
    class IngressoVip:Ingresso
    {
        private double precoVip = 25.00;

        public double PrecoVip
        {
            get { return precoVip; }
            set { precoVip = value; }
        }
        public override double ImprimirValor()
        {
            Valor = precoVip + Valor;
            return Valor;
        }
    }
}
