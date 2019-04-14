using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Valor_Ingresso
{
    class IngressoNormal:Ingresso
    {
        private double valorNormal;

        public double ValorNormal
        {
            get { return valorNormal; }
            set { valorNormal = value; }
        }

        public override double ImprimirValor()
        {
            valorNormal = Valor;
            return valorNormal;
        }

    }
}
